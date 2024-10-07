using Azure;
using Azure.Communication.JobRouter;
using AzureCommunicationServicesJobRouter.BindingModels;
using JobRouterEventParser;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ServiceBusReceiver;
using System.ComponentModel;
using System.Text;

namespace AzureCommunicationServicesJobRouter
{
    public partial class frmMain : Form
    {
        private ConfigWrapper _configWrapper;

        private ServiceBusReceiverManager _serviceBusReceiverManager;

        private Parser _routerEventParser = new Parser();

        private JobRouterAdministrationClient _routerAdminClient;
        private JobRouterClient _routerClient;

        private BindingList<DistributionPolicyBinding> _distributionPolicyBindingList = new BindingList<DistributionPolicyBinding>();
        private BindingSource _distributionPolicyBindingSource;

        private BindingList<QueueBinding> _queueBindingList = new BindingList<QueueBinding>();
        private BindingSource _queueBindingSource;

        private BindingList<WorkerBinding> _workerBindingList = new BindingList<WorkerBinding>();
        private BindingSource _workerBindingSource;

        private BindingList<JobBinding> _jobBindingList = new BindingList<JobBinding>();
        private BindingSource _jobBindingSource;

        private class DgWorkersColumnIndex
        {
            public const int Id = 0;
            public const int State = 1;
            public const int Offers = 2;
            public const int AssignedJobs = 3;
            public const int Capacity = 4;
            public const int MaxConcurrentOffers = 5;
            public const int Queues = 6;
            public const int Channels = 7;
            public const int Labels = 8;
            public const int LoadRatio = 9;
        }

        private class DgJobsColumnIndex
        {
            public const int Id = 0;
            public const int Status = 1;
            public const int DispositionCode = 2;
            public const int Assignments = 3;
            public const int EnqueueAt = 4;
            public const int ScheduleAt = 5;
            public const int Priority = 6;
            public const int ChannelId = 7;
            public const int QueueId = 8;
            public const int MatchingMode = 9;
            public const int RequestedWorkerSelection = 10;
            public const int Notes = 11;
        }

        public frmMain()
        {
            InitializeComponent();

            _configWrapper = new ConfigWrapper(new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               //.AddEnvironmentVariables()
               .Build());

            Text += $" (v{Helper.GetApplicationVersion()})";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WriteTrace($"Starting application v{Helper.GetApplicationVersion()}...");

            WriteTrace($"AppSettings Config:\r\n" +
                $"\t AcsConnectionString: {Helper.MaskConnectionString(_configWrapper.AcsConnectionString)}\r\n" +
                $"\t ServiceBusConnectionString: {Helper.MaskConnectionString(_configWrapper.ServiceBusConnectionString)}\r\n" +
                $"\t ServiceBusQueueName: {_configWrapper.ServiceBusQueueName}");

            _serviceBusReceiverManager = new ServiceBusReceiverManager(_configWrapper.ServiceBusConnectionString, _configWrapper.ServiceBusQueueName);
            _serviceBusReceiverManager.ServiceBusEvent += HandleServiceBusEvent_Handler;
            _serviceBusReceiverManager.Start();

            _routerAdminClient = new JobRouterAdministrationClient(_configWrapper.AcsConnectionString);
            _routerClient = new JobRouterClient(_configWrapper.AcsConnectionString);

            _distributionPolicyBindingSource = new BindingSource(_distributionPolicyBindingList, null);
            dgDistributionPolicies.DataSource = _distributionPolicyBindingSource;

            _queueBindingSource = new BindingSource(_queueBindingList, null);
            dgQueues.DataSource = _queueBindingSource;

            _workerBindingSource = new BindingSource(_workerBindingList, null);
            dgWorkers.DataSource = _workerBindingSource;

            _jobBindingSource = new BindingSource(_jobBindingList, null);
            dgJobs.DataSource = _jobBindingSource;

            RefreshLists();
        }

        private void RefreshLists()
        {
            WriteTrace($"Refreshing lists...");

            RefreshDistributionPolicies();
            RefreshQueues();
            RefreshWorkers();
            RefreshJobs();

            WriteTrace($"Refreshing done successfully!");
        }

        #region Distribution policies
        private async void RefreshDistributionPolicies()
        {
            if (dgDistributionPolicies.InvokeRequired)
            {
                dgDistributionPolicies.Invoke(() =>
                {
                    RefreshDistributionPolicies();
                });
            }
            else
            {
                var distributionPolicies = _routerAdminClient.GetDistributionPoliciesAsync();

                _distributionPolicyBindingList.Clear();

                await foreach (var policy in distributionPolicies)
                {
                    AddDistributionPolicyBinding(policy);
                }
            }
        }

        private void AddDistributionPolicyBinding(DistributionPolicy distributionPolicy)
        {
            if (dgDistributionPolicies.InvokeRequired)
            {
                dgDistributionPolicies.Invoke(() =>
                {
                    AddDistributionPolicyBinding(distributionPolicy);
                });
            }
            else
            {
                _distributionPolicyBindingList.Add(distributionPolicy.ToDistributionPolicyBinding());
            }
        }

        private int GetDistributionPolicyBindingIndex(string policyId)
        {
            int i = 0;

            for (i = 0; i < _distributionPolicyBindingList.Count; i++)
            {
                if (_distributionPolicyBindingList[i].Id == policyId)
                {
                    break;
                }
            }

            return i;
        }

        private List<string> GetDistributionPoliciesId()
        {
            return _distributionPolicyBindingList.Select(p => p.Id).ToList();
        }

        private void UpdateDistributionPolicyBinding(DistributionPolicy distributionPolicy)
        {
            if (dgDistributionPolicies.InvokeRequired)
            {
                dgDistributionPolicies.Invoke(() =>
                {
                    UpdateDistributionPolicyBinding(distributionPolicy);
                });
            }
            else
            {
                int policyBindingIndex = GetDistributionPolicyBindingIndex(distributionPolicy.Id);

                _distributionPolicyBindingList[policyBindingIndex] = distributionPolicy.ToDistributionPolicyBinding();
            }
        }

        private void RemoveDistributionPolicyBinding(string policyId)
        {
            if (dgDistributionPolicies.InvokeRequired)
            {
                dgDistributionPolicies.Invoke(() =>
                {
                    RemoveDistributionPolicyBinding(policyId);
                });
            }
            else
            {
                _distributionPolicyBindingList.Remove(_distributionPolicyBindingList.Single(d => d.Id == policyId));
            }
        }
        #endregion

        #region Queues
        private async void RefreshQueues()
        {
            if (dgQueues.InvokeRequired)
            {
                dgQueues.Invoke(() =>
                {
                    RefreshQueues();
                });
            }
            else
            {
                var queues = _routerAdminClient.GetQueuesAsync();

                _queueBindingList.Clear();

                await foreach (var queue in queues)
                {
                    AddQueueBinding(queue);
                }
            }
        }

        private void AddQueueBinding(RouterQueue routerQueue)
        {
            if (dgQueues.InvokeRequired)
            {
                dgQueues.Invoke(() =>
                {
                    AddQueueBinding(routerQueue);
                });
            }
            else
            {
                _queueBindingList.Add(routerQueue.ToQueueBinding());
            }
        }

        private void RemoveQueueBinding(string queueId)
        {
            if (dgQueues.InvokeRequired)
            {
                dgQueues.Invoke(() =>
                {
                    RemoveQueueBinding(queueId);
                });
            }
            else
            {
                _queueBindingList.Remove(_queueBindingList.Single(q => q.Id == queueId));
            }
        }

        private int GetQueueBindingIndex(string queueId)
        {
            int i = 0;

            for (i = 0; i < _queueBindingList.Count; i++)
            {
                if (_queueBindingList[i].Id == queueId)
                {
                    break;
                }
            }

            return i;
        }

        private void UpdateQueueBinding(RouterQueue queue)
        {
            if (dgQueues.InvokeRequired)
            {
                dgQueues.Invoke(() =>
                {
                    UpdateQueueBinding(queue);
                });
            }
            else
            {
                int queueBindingIndex = GetQueueBindingIndex(queue.Id);

                _queueBindingList[queueBindingIndex] = queue.ToQueueBinding();
            }
        }

        private List<string> GetQueuesIds()
        {
            return _queueBindingList.Select(q => q.Id).ToList();
        }
        #endregion

        #region Workers
        private async void RefreshWorkers()
        {
            if (dgWorkers.InvokeRequired)
            {
                dgWorkers.Invoke(() =>
                {
                    RefreshWorkers();
                });
            }
            else
            {
                var workers = _routerClient.GetWorkersAsync();

                _workerBindingList.Clear();

                await foreach (var worker in workers)
                {
                    AddWorkerBinding(worker);
                }
            }
        }

        private void AddWorkerBinding(RouterWorker routerWorker)
        {
            if (dgWorkers.InvokeRequired)
            {
                dgWorkers.Invoke(() =>
                {
                    AddWorkerBinding(routerWorker);
                });
            }
            else
            {
                _workerBindingList.Add(routerWorker.ToWorkerBinding());
            }
        }

        private void RemoveWorkerBinding(string workerId)
        {
            if (dgWorkers.InvokeRequired)
            {
                dgWorkers.Invoke(() =>
                {
                    RemoveWorkerBinding(workerId);
                });
            }
            else
            {
                _workerBindingList.Remove(_workerBindingList.Single(w => w.Id == workerId));
            }
        }

        private int GetWorkerBindingIndex(string workerId)
        {
            int i = 0;

            for (i = 0; i < _workerBindingList.Count; i++)
            {
                if (_workerBindingList[i].Id == workerId)
                {
                    break;
                }
            }

            return i;
        }

        private void UpdateWorkerBinding(RouterWorker worker)
        {
            if (dgWorkers.InvokeRequired)
            {
                dgWorkers.Invoke(() =>
                {
                    UpdateWorkerBinding(worker);
                });
            }
            else
            {
                int workerBindingIndex = GetWorkerBindingIndex(worker.Id);

                _workerBindingList[workerBindingIndex] = worker.ToWorkerBinding();
            }
        }

        private List<RouterChannel> GetUniqueWorkersChannels()
        {
            List<RouterChannel> channelsList = new List<RouterChannel>();

            foreach (var worker in _workerBindingList)
            {
                channelsList = channelsList.UnionBy(worker.ChannlesList, c => c.ChannelId).ToList();
            }

            return channelsList;
        }
        #endregion

        #region Jobs
        private async void RefreshJobs()
        {
            if (dgJobs.InvokeRequired)
            {
                dgJobs.Invoke(() =>
                {
                    RefreshJobs();
                });
            }
            else
            {
                var jobs = _routerClient.GetJobsAsync();

                _jobBindingList.Clear();

                await foreach (var job in jobs)
                {
                    AddJobBinding(job);
                }
            }
        }

        private void AddJobBinding(RouterJob job)
        {
            if (dgJobs.InvokeRequired)
            {
                dgJobs.Invoke(() =>
                {
                    AddJobBinding(job);
                });
            }
            else
            {
                _jobBindingList.Add(job.ToJobBinding());
            }
        }

        private void RemoveJobBinding(string jobId)
        {
            if (dgJobs.InvokeRequired)
            {
                dgJobs.Invoke(() =>
                {
                    RemoveJobBinding(jobId);
                });
            }
            else
            {
                _jobBindingList.Remove(_jobBindingList.Single(j => j.Id == jobId));
            }
        }

        private int GetJobBindingIndex(string jobId)
        {
            int i = 0;

            for (i = 0; i < _jobBindingList.Count; i++)
            {
                if (_jobBindingList[i].Id == jobId)
                {
                    break;
                }
            }

            return i;
        }

        private void UpdateJobBinding(RouterJob job)
        {
            if (dgJobs.InvokeRequired)
            {
                dgJobs.Invoke(() =>
                {
                    UpdateJobBinding(job);
                });
            }
            else
            {
                int jobBindingindex = GetJobBindingIndex(job.Id);

                _jobBindingList[jobBindingindex] = job.ToJobBinding();
            }
        }
        #endregion

        #region ServiceBus handlers
        private void HandleServiceBusEvent_Handler(object sender, ServiceBusEventArgs e)
        {
            WriteTrace($"<--- EVENT RECEIVED: {e.Body}");

            RouterEventBase routerEventBase = _routerEventParser.Parse(e.Body);

            if (routerEventBase != null)
            {
                switch (routerEventBase.EventType)
                {
                    case RouterEventType.RouterWorkerUpdated:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerUpdated)routerEventBase).Data.WorkerId);
                        break;

                    case RouterEventType.RouterWorkerOfferIssued:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerOfferIssued)routerEventBase).Data.WorkerId);
                        break;

                    case RouterEventType.RouterWorkerOfferExpired:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerOfferExpired)routerEventBase).Data.WorkerId);
                        break;

                    case RouterEventType.RouterWorkerOfferAccepted:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerOfferAccepted)routerEventBase).Data.WorkerId);
                        HandleServiceBusEvent_RouterJobUpdated(((RouterWorkerOfferAccepted)routerEventBase).Data.JobId);
                        break;

                    case RouterEventType.RouterWorkerOfferDeclined:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerOfferDeclined)routerEventBase).Data.WorkerId);
                        break;

                    case RouterEventType.RouterWorkerRegistered:
                    case RouterEventType.RouterWorkerDeregistered:
                        //Do nothing
                        break;

                    case RouterEventType.RouterWorkerOfferRevoked:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterWorkerOfferRevoked)routerEventBase).Data.WorkerId);
                        break;

                    case RouterEventType.RouterJobReceived:
                        //Do nothing??
                        break;

                    case RouterEventType.RouterJobQueued:
                        HandleServiceBusEvent_RouterJobUpdated(((RouterJobQueued)routerEventBase).Data.JobId);
                        break;

                    case RouterEventType.RouterJobCompleted:
                        HandleServiceBusEvent_RouterJobUpdated(((RouterJobCompleted)routerEventBase).Data.JobId);
                        break;

                    case RouterEventType.RouterJobCancelled:
                        HandleServiceBusEvent_RouterJobUpdated(((RouterJobCancelled)routerEventBase).Data.JobId);
                        break;

                    case RouterEventType.RouterJobClosed:
                        HandleServiceBusEvent_RouterWorkerUpdated(((RouterJobClosed)routerEventBase).Data.WorkerId);
                        HandleServiceBusEvent_RouterJobUpdated(((RouterJobClosed)routerEventBase).Data.JobId);
                        break;

                    case RouterEventType.RouterJobWaitingForActivation:
                        HandleServiceBusEvent_RouterJobUpdated(((RouterJobWaitingForActivation)routerEventBase).Data.JobId);
                        break;

                    default:
                        WriteTrace("^^^ DEFAULT NOT PARSED : PLEASE MAKE A MANUAL REFRESH (CTRL + R) ^^^");
                        break;
                }
            }
            else
            {
                WriteTrace("^^^ NOT PARSED : PLEASE MAKE A MANUAL REFRESH (CTRL + R) ^^^");
            }
        }

        private async void HandleServiceBusEvent_RouterWorkerUpdated(string workerId)
        {

            RouterWorker routerWorker = await _routerClient.GetWorkerAsync(workerId);
            UpdateWorkerBinding(routerWorker);
        }

        private async void HandleServiceBusEvent_RouterJobUpdated(string jobId)
        {
            RouterJob routerJob = await _routerClient.GetJobAsync(jobId);
            UpdateJobBinding(routerJob);
        }
        #endregion

        #region Logging
        private void WriteTrace(string message)
        {
            if (txtTrace.InvokeRequired)
            {
                txtTrace.Invoke(new Action(() =>
                {
                    WriteTrace(message);
                }));
            }
            else
            {
                txtTrace.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message} {Environment.NewLine} {Environment.NewLine}");
            }
        }

        public void HandleUncaughtException(Exception ex)
        {
            if (ex is RequestFailedException)
            {
                MessageBox.Show($"{ex.Message}", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{ex.Message} {Environment.NewLine} {ex.StackTrace}", "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            WriteException(ex);
        }

        private void WriteException(Exception ex)
        {
            if (txtTrace.InvokeRequired)
            {
                txtTrace.Invoke(new Action(() =>
                {
                    WriteException(ex);
                }));
            }
            else
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException)ex).Flatten();
                }

                txtTrace.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] Exception occured! {Environment.NewLine}" +
                  $"================================================== {Environment.NewLine}" +
                  $"{ex.Message.TrimEnd()}" +
                  $"{Environment.NewLine}=================================================={Environment.NewLine}{Environment.NewLine}");
            }
        }
        #endregion

        #region Dleete later
        public async void QuickStart()
        {
            string uniqueId = "-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            string policyID = "distribution-policy" + uniqueId;
            string policyName = "My distribution policy" + uniqueId;

            string queueId = "queue" + uniqueId;
            string queueName = "My Queue" + uniqueId;

            string jobId = "job" + uniqueId;
            string channelId = "voice" + uniqueId;

            string workerSelectorKey = "Some-Skill" + uniqueId;

            string workerId = "worker" + uniqueId;

            var distributionPolicy = await _routerAdminClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: policyID,
                    offerExpiresAfter: TimeSpan.FromMinutes(1),
                    mode: new LongestIdleMode())
                {
                    Name = policyName
                });


            var queue = await _routerAdminClient.CreateQueueAsync(new CreateQueueOptions(queueId: queueId, distributionPolicyId: distributionPolicy.Value.Id)
            {
                Name = queueName
            });

            var job = await _routerClient.CreateJobAsync(new CreateJobOptions(jobId: jobId, channelId: channelId, queueId: queue.Value.Id)
            {
                Priority = 1,
                RequestedWorkerSelectors = { new RouterWorkerSelector(key: workerSelectorKey, labelOperator: LabelOperator.GreaterThan, value: new RouterValue(10)) },
            });

            var worker = await _routerClient.CreateWorkerAsync(new CreateWorkerOptions(workerId: workerId, capacity: 1)
            {
                Queues = { queue.Value.Id },
                Labels = { [workerSelectorKey] = new RouterValue(11) },
                Channels = { new RouterChannel(channelId: channelId, capacityCostPerJob: 1) },
                AvailableForOffers = true,
            });

            await Task.Delay(TimeSpan.FromSeconds(10));
            worker = await _routerClient.GetWorkerAsync(worker.Value.Id);
            foreach (var offer in worker.Value.Offers)
            {
                Console.WriteLine($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
                WriteTrace($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
            }

            var accept = await _routerClient.AcceptJobOfferAsync(workerId: worker.Value.Id, offerId: worker.Value.Offers.FirstOrDefault().OfferId);
            Console.WriteLine($"Worker {worker.Value.Id} is assigned job {accept.Value.JobId}");
            WriteTrace($"Worker {worker.Value.Id} is assigned job {accept.Value.JobId}");

            //await _routerClient.CompleteJobAsync(new CompleteJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId));
            //Console.WriteLine($"Worker {worker.Value.Id} has completed job {accept.Value.JobId}");
            //WriteTrace($"Worker {worker.Value.Id} has completed job {accept.Value.JobId}");

            //await _routerClient.CloseJobAsync(new CloseJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId)
            //{
            //    DispositionCode = "Resolved"
            //});
            //Console.WriteLine($"Worker {worker.Value.Id} has closed job {accept.Value.JobId}");
            //WriteTrace($"Worker {worker.Value.Id} has closed job {accept.Value.JobId}");

            //await _routerClient.DeleteJobAsync(accept.Value.JobId);
            //Console.WriteLine($"Deleting job {accept.Value.JobId}");
            //WriteTrace($"Deleting job {accept.Value.JobId}");

            ////Mark worker as unavilable for offers
            //worker.Value.AvailableForOffers = false;
            //worker = await _routerClient.UpdateWorkerAsync(worker);
            //WriteTrace($"Mark worker {worker.Value.Id} as unaviable for offers");

            //await _routerClient.DeleteWorkerAsync(workerId);
            //WriteTrace($"Delete worker {worker.Value.Id}");
        }

        public async void QuickStart2()
        {
            var distributionPolicy = await _routerAdminClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: "distribution-policy-11",
                    offerExpiresAfter: TimeSpan.FromMinutes(1),
                    mode: new LongestIdleMode())
                {
                    Name = "My distribution policy1"
                });

            var queue = await _routerAdminClient.CreateQueueAsync(new CreateQueueOptions(queueId: "queue-11", distributionPolicyId: distributionPolicy.Value.Id)
            {
                Name = "My Queue1"
            });

            var job = await _routerClient.CreateJobAsync(new CreateJobOptions(jobId: "job-11", channelId: "voice1", queueId: queue.Value.Id)
            {
                Priority = 1,
                RequestedWorkerSelectors = { new RouterWorkerSelector(key: "Some-Skill1", labelOperator: LabelOperator.GreaterThan, value: new RouterValue(10)) }
            });

            var worker1 = await _routerClient.CreateWorkerAsync(new CreateWorkerOptions(workerId: "worker-11", capacity: 1)
            {
                Queues = { queue.Value.Id },
                Labels = { ["Some-Skill1"] = new RouterValue(11) },
                Channels = { new RouterChannel(channelId: "voice1", capacityCostPerJob: 1) },
                AvailableForOffers = true,
            });

            await Task.Delay(TimeSpan.FromSeconds(5));

            var worker2 = await _routerClient.CreateWorkerAsync(new CreateWorkerOptions(workerId: "worker-21", capacity: 1)
            {
                Queues = { queue.Value.Id },
                Labels = { ["Some-Skill1"] = new RouterValue(12) },
                Channels = { new RouterChannel(channelId: "voice1", capacityCostPerJob: 1) },
                AvailableForOffers = true,
            });


            //First offer
            await Task.Delay(TimeSpan.FromSeconds(15));
            worker1 = await _routerClient.GetWorkerAsync(worker1.Value.Id);
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker1.Value.Id} has an active offer for job {offer.JobId}");
            }

            if (worker1.Value.Offers.Count > 0)
            {
                await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker1.Value.Id, worker1.Value.Offers.FirstOrDefault().OfferId)
                {
                    RetryOfferAt = DateTime.Now.AddSeconds(10)
                });
            }

            worker2 = await _routerClient.GetWorkerAsync(worker2.Value.Id);
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker2.Value.Id} has an active offer for job {offer.JobId}");
            }
            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker2.Value.Id, worker2.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });

            //Second offer
            await Task.Delay(TimeSpan.FromSeconds(15));
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker1.Value.Id} has an active offer for job {offer.JobId}");
            }

            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker1.Value.Id, worker1.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });

            worker2 = await _routerClient.GetWorkerAsync(worker2.Value.Id);
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker2.Value.Id} has an active offer for job {offer.JobId}");
            }
            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker2.Value.Id, worker2.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });


            //Third offer
            await Task.Delay(TimeSpan.FromSeconds(15));
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker1.Value.Id} has an active offer for job {offer.JobId}");
            }

            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker1.Value.Id, worker1.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });

            worker2 = await _routerClient.GetWorkerAsync(worker2.Value.Id);
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker2.Value.Id} has an active offer for job {offer.JobId}");
            }
            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker2.Value.Id, worker2.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });

            //Fourth offer
            await Task.Delay(TimeSpan.FromSeconds(15));
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker1.Value.Id} has an active offer for job {offer.JobId}");
            }

            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker1.Value.Id, worker1.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });

            worker2 = await _routerClient.GetWorkerAsync(worker2.Value.Id);
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker2.Value.Id} has an active offer for job {offer.JobId}");
            }
            await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker2.Value.Id, worker2.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTime.Now.AddSeconds(10)
            });


            //Accept offer
            await Task.Delay(TimeSpan.FromSeconds(15));
            foreach (var offer in worker1.Value.Offers)
            {
                Console.WriteLine($"Worker {worker1.Value.Id} has an active offer for job {offer.JobId}");
            }

            var accept = await _routerClient.AcceptJobOfferAsync(workerId: worker1.Value.Id, offerId: worker1.Value.Offers.FirstOrDefault().OfferId);
            Console.WriteLine($"Worker {worker1.Value.Id} is assigned job {accept.Value.JobId}");

            await _routerClient.CompleteJobAsync(new CompleteJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId));
            Console.WriteLine($"Worker {worker1.Value.Id} has completed job {accept.Value.JobId}");

            await _routerClient.CloseJobAsync(new CloseJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId)
            {
                DispositionCode = "Resolved"
            });
            Console.WriteLine($"Worker {worker1.Value.Id} has closed job {accept.Value.JobId}");

            await _routerClient.DeleteJobAsync(accept.Value.JobId);
            Console.WriteLine($"Deleting job {accept.Value.JobId}");
        }


        public async void QuickStart3()
        {
            string uniqueId = "-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            string policyID = "distribution-policy" + uniqueId;
            string policyName = "My distribution policy" + uniqueId;

            string queueId = "queue" + uniqueId;
            string queueName = "My Queue" + uniqueId;

            string jobId = "job" + uniqueId;
            string channelId = "voice" + uniqueId;

            string workerSelectorKey = "Some-Skill" + uniqueId;

            string workerId = "worker" + uniqueId;

            var distributionPolicy = await _routerAdminClient.CreateDistributionPolicyAsync(
                new CreateDistributionPolicyOptions(
                    distributionPolicyId: policyID,
                    offerExpiresAfter: TimeSpan.FromMinutes(1),
                    mode: new LongestIdleMode())
                {
                    Name = policyName
                });

            var queue = await _routerAdminClient.CreateQueueAsync(new CreateQueueOptions(queueId: queueId, distributionPolicyId: distributionPolicy.Value.Id)
            {
                Name = queueName
            });

            var job = await _routerClient.CreateJobAsync(new CreateJobOptions(jobId: jobId, channelId: channelId, queueId: queue.Value.Id)
            {
                Priority = 1,
                RequestedWorkerSelectors = { new RouterWorkerSelector(key: workerSelectorKey, labelOperator: LabelOperator.GreaterThan, value: new RouterValue(10)) }
            });

            var worker = await _routerClient.CreateWorkerAsync(new CreateWorkerOptions(workerId: workerId, capacity: 1)
            {
                Queues = { queue.Value.Id },
                Labels = { [workerSelectorKey] = new RouterValue(11) },
                Channels = { new RouterChannel(channelId: channelId, capacityCostPerJob: 1) },
                AvailableForOffers = true
            });

            await Task.Delay(TimeSpan.FromSeconds(10));

            worker = await _routerClient.GetWorkerAsync(worker.Value.Id);
            foreach (var offer in worker.Value.Offers)
            {
                Console.WriteLine($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
            }

            var decline = await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(worker.Value.Id, worker.Value.Offers.FirstOrDefault().OfferId)
            {
                RetryOfferAt = DateTimeOffset.UtcNow.AddSeconds(90)
            });
            WriteTrace($"Worker {worker.Value.Id} delclined job");
            Console.WriteLine($"Worker {worker.Value.Id} delclined job");

            //Check if offers available
            await Task.Delay(TimeSpan.FromSeconds(10));
            worker = await _routerClient.GetWorkerAsync(worker.Value.Id);
            foreach (var offer in worker.Value.Offers)
            {
                WriteTrace($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
                Console.WriteLine($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
            }

            await Task.Delay(TimeSpan.FromSeconds(100));
            worker = await _routerClient.GetWorkerAsync(worker.Value.Id);
            foreach (var offer in worker.Value.Offers)
            {
                WriteTrace($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
                Console.WriteLine($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
            }

            var accept = await _routerClient.AcceptJobOfferAsync(workerId: worker.Value.Id, offerId: worker.Value.Offers.FirstOrDefault().OfferId);
            WriteTrace($"Worker {worker.Value.Id} is assigned job {accept.Value.JobId}");
            Console.WriteLine($"Worker {worker.Value.Id} is assigned job {accept.Value.JobId}");

            await _routerClient.CompleteJobAsync(new CompleteJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId));
            WriteTrace($"Worker {worker.Value.Id} has completed job {accept.Value.JobId}");
            Console.WriteLine($"Worker {worker.Value.Id} has completed job {accept.Value.JobId}");

            await _routerClient.CloseJobAsync(new CloseJobOptions(jobId: accept.Value.JobId, assignmentId: accept.Value.AssignmentId)
            {
                DispositionCode = "Resolved"
            });
            WriteTrace($"Worker {worker.Value.Id} has closed job {accept.Value.JobId}");
            Console.WriteLine($"Worker {worker.Value.Id} has closed job {accept.Value.JobId}");

            await _routerClient.DeleteJobAsync(accept.Value.JobId);
            WriteTrace($"Deleting job {accept.Value.JobId}");
            Console.WriteLine($"Deleting job {accept.Value.JobId}");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            QuickStart();
        }
        #endregion

        #region UI helpers
        private List<string> GetSelectedDataGridViewIds(DataGridView dataGridView, int idColIndex = 0)
        {
            List<string> SelectedRowsId = new List<string>();
            string tempId;

            //Get row selection
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgRow in dataGridView.SelectedRows)
                {
                    tempId = dgRow.Cells[idColIndex].Value.ToString();

                    if (SelectedRowsId.Any(p => p == tempId) == false)
                    {
                        SelectedRowsId.Insert(0, tempId);
                    }
                }
            }

            //Get cell selection
            if (dataGridView.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell dgRow in dataGridView.SelectedCells)
                {
                    tempId = dataGridView.Rows[dgRow.RowIndex].Cells[idColIndex].Value.ToString();

                    if (SelectedRowsId.Any(p => p == tempId) == false)
                    {
                        SelectedRowsId.Insert(0, tempId);
                    }
                }
            }

            return SelectedRowsId;
        }

        public class WorkerOfferCustom
        {
            public string OfferId { get; set; }

            public string JobId { get; set; }

            public int CapacityCost { get; set; }

            public DateTimeOffset OfferedAt { get; set; }

            public DateTimeOffset ExpiresAt { get; set; }
        }

        private class RouterJobAssignmentCustom
        {
            public string AssignmentId { get; set; }

            public string WorkerId { get; set; }

            public DateTimeOffset? AssignedAt { get; set; }

            public DateTimeOffset? CompletedAt { get; set; }

            public DateTimeOffset? ClosedAt { get; set; }
        }
        #endregion

        #region Distribution policies UI
        private async void btnCreateDistPolicy_Click(object sender, EventArgs e)
        {
            frmUpsertDistributionPolicy frmCreateDistributionPolicy = new frmUpsertDistributionPolicy(false);

            if (frmCreateDistributionPolicy.ShowDialog() == DialogResult.OK)
            {
                DistributionPolicy distributionPolicy = frmCreateDistributionPolicy.Policy;

                distributionPolicy = await _routerAdminClient.CreateDistributionPolicyAsync(new CreateDistributionPolicyOptions(distributionPolicy.Id, distributionPolicy.OfferExpiresAfter.Value, distributionPolicy.Mode)
                {
                    Name = distributionPolicy.Name
                });

                //To-do: Check if update
                AddDistributionPolicyBinding(distributionPolicy);
            }
        }

        private async void btnUpdateDistPolicy_Click(object sender, EventArgs e)
        {
            List<string> distPolicyIds = GetSelectedDataGridViewIds(dgDistributionPolicies);

            if (distPolicyIds.Count == 1)
            {
                DistributionPolicy distributionPolicy = await _routerAdminClient.GetDistributionPolicyAsync(distPolicyIds.First());

                frmUpsertDistributionPolicy frmUpdateDistributionPolicy = new frmUpsertDistributionPolicy(true, distributionPolicy);

                if (frmUpdateDistributionPolicy.ShowDialog() == DialogResult.OK)
                {
                    distributionPolicy = await _routerAdminClient.UpdateDistributionPolicyAsync(frmUpdateDistributionPolicy.Policy);

                    UpdateDistributionPolicyBinding(distributionPolicy);
                }
            }
            else if (distPolicyIds.Count == 0)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please select a single distribution policy. Cannot edit multiple policies", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeleteDistPolicy_Click(object sender, EventArgs e)
        {
            List<string> distPolicyIds = GetSelectedDataGridViewIds(dgDistributionPolicies);

            if (distPolicyIds.Count > 0)
            {
                foreach (var policyId in distPolicyIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete distribution policy with Id '{policyId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var deleteResult = await _routerAdminClient.DeleteDistributionPolicyAsync(policyId);

                        if (deleteResult.IsError == false)
                        {
                            RemoveDistributionPolicyBinding(policyId);
                        }
                    }
                }
            }
        }
        #endregion

        #region Queues UI
        private async void btnCreateQueue_Click(object sender, EventArgs e)
        {
            frmUpsertQueue frmCreateQueue = new frmUpsertQueue(false, GetDistributionPoliciesId());

            if (frmCreateQueue.ShowDialog() == DialogResult.OK)
            {
                RouterQueue routerQueue = frmCreateQueue.Queue;

                routerQueue = await _routerAdminClient.CreateQueueAsync(new CreateQueueOptions(routerQueue.Id, routerQueue.DistributionPolicyId)
                {
                    Name = routerQueue.Name
                });

                //To-do: check if update
                AddQueueBinding(routerQueue);
            }
        }

        private async void btnUpdateQueue_Click(object sender, EventArgs e)
        {
            List<string> queueIds = GetSelectedDataGridViewIds(dgQueues);

            if (queueIds.Count == 1)
            {
                RouterQueue routerQueue = await _routerAdminClient.GetQueueAsync(queueIds.First());

                frmUpsertQueue frmUpdateQueue = new frmUpsertQueue(true, GetDistributionPoliciesId(), routerQueue);

                if (frmUpdateQueue.ShowDialog() == DialogResult.OK)
                {
                    routerQueue = await _routerAdminClient.UpdateQueueAsync(frmUpdateQueue.Queue);

                    UpdateQueueBinding(routerQueue);
                }
            }
            else if (queueIds.Count == 0)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please select a single queue. Cannot edit multiple queues", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeleteQueue_Click(object sender, EventArgs e)
        {
            List<string> queueIds = GetSelectedDataGridViewIds(dgQueues);

            if (queueIds.Count > 0)
            {
                foreach (var queueId in queueIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete queue with Id '{queueId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var deleteResult = await _routerAdminClient.DeleteQueueAsync(queueId);

                        if (deleteResult.IsError == false)
                        {
                            RemoveQueueBinding(queueId);
                        }
                    }
                }
            }
        }
        #endregion

        #region Workers UI
        private async void btnCreateWorker_Click(object sender, EventArgs e)
        {
            frmUpsertWorker frmCreateWorker = new frmUpsertWorker(false, GetQueuesIds(), GetUniqueWorkersChannels());

            if (frmCreateWorker.ShowDialog() == DialogResult.OK)
            {
                RouterWorker routerWorker = frmCreateWorker.Worker;

                var createWorkerOptions = new CreateWorkerOptions(routerWorker.Id, routerWorker.Capacity.Value)
                {
                    AvailableForOffers = routerWorker.AvailableForOffers.Value,
                    MaxConcurrentOffers = routerWorker.MaxConcurrentOffers,
                };

                foreach (var channel in routerWorker.Channels)
                {
                    createWorkerOptions.Channels.Add(channel);
                }

                foreach (var label in routerWorker.Labels)
                {
                    createWorkerOptions.Labels.Add(label);
                }

                foreach (var queue in routerWorker.Queues)
                {
                    createWorkerOptions.Queues.Add(queue);
                }

                routerWorker = await _routerClient.CreateWorkerAsync(createWorkerOptions);

                AddWorkerBinding(routerWorker);
            }
        }

        private async void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            List<string> workerIds = GetSelectedDataGridViewIds(dgWorkers);

            if (workerIds.Count == 1)
            {
                List<RouterChannel> channelsList = GetUniqueWorkersChannels();

                RouterWorker routerWorker = await _routerClient.GetWorkerAsync(workerIds.First());

                frmUpsertWorker frmUpdateWorker = new frmUpsertWorker(true, GetQueuesIds(), channelsList, routerWorker);

                if (frmUpdateWorker.ShowDialog() == DialogResult.OK)
                {
                    routerWorker = frmUpdateWorker.Worker;

                    routerWorker = await _routerClient.UpdateWorkerAsync(routerWorker);
                }
            }
            else if (workerIds.Count == 0)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please select a single worker. Cannot update multiple workers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            List<string> workerIds = GetSelectedDataGridViewIds(dgWorkers);

            if (workerIds.Count > 0)
            {
                foreach (var workerId in workerIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete worker with Id '{workerId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var deleteResult = await _routerClient.DeleteWorkerAsync(workerId);

                        if (deleteResult.IsError == false)
                        {
                            RemoveWorkerBinding(workerId);
                        }
                    }
                }
            }
        }

        private async void btnRespondToOffer_Click(object sender, EventArgs e)
        {
            //To-do: Support responding to multiple offers
            List<string> workerIds = GetSelectedDataGridViewIds(dgWorkers);

            if (workerIds.Count == 1)
            {
                WorkerBinding workerBinding = _workerBindingList.First(w => w.Id == workerIds.First());

                List<WorkerOfferCustom> workerOfferCustom = JsonConvert.DeserializeObject<List<WorkerOfferCustom>>(workerBinding.Offers);

                frmRespondToJobOffer frmRespondToJobOffer = new frmRespondToJobOffer(workerOfferCustom);

                if (frmRespondToJobOffer.ShowDialog() == DialogResult.OK)
                {
                    if (frmRespondToJobOffer.JobOfferRespone.AcceptOffer)
                    {
                        AcceptJobOfferResult acceptJobOfferResult = await _routerClient.AcceptJobOfferAsync(workerBinding.Id, frmRespondToJobOffer.JobOfferRespone.OfferId);
                    }
                    else
                    {
                        var declineJobOfferResponse = await _routerClient.DeclineJobOfferAsync(new DeclineJobOfferOptions(workerBinding.Id, frmRespondToJobOffer.JobOfferRespone.OfferId)
                        {
                            RetryOfferAt = frmRespondToJobOffer.JobOfferRespone.RetryAfter
                        });
                    }
                }
            }
            else if (workerIds.Count == 0)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please select a single worker. Cannot respond to offers for multiple workers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnRegisterWorker_Click(object sender, EventArgs e)
        {
            List<string> workerIds = GetSelectedDataGridViewIds(dgWorkers);

            if (workerIds.Count > 0)
            {
                foreach (var workerId in workerIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to re-register worker with Id '{workerId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var worker = await _routerClient.GetWorkerAsync(workerId);

                        worker.Value.AvailableForOffers = true;

                        worker = await _routerClient.UpdateWorkerAsync(worker);
                    }
                }
            }
        }

        private async void btnDeregisterWorker_Click(object sender, EventArgs e)
        {
            List<string> workerIds = GetSelectedDataGridViewIds(dgWorkers);

            if (workerIds.Count > 0)
            {
                foreach (var workerId in workerIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to deregister worker with Id '{workerId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var worker = await _routerClient.GetWorkerAsync(workerId);

                        worker.Value.AvailableForOffers = false;

                        worker = await _routerClient.UpdateWorkerAsync(worker);
                    }
                }
            }
        }

        private void dgWorkers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgWorkers.Rows)
            {
                string workerState = row.Cells[DgWorkersColumnIndex.State].Value.ToString().ToLower();
                bool hasOffers = row.Cells[DgWorkersColumnIndex.Offers].Value.ToString() != "[]";
                bool hasAssignedJobs = row.Cells[DgWorkersColumnIndex.AssignedJobs].Value.ToString() != "[]";

                if (hasOffers)
                {
                    row.DefaultCellStyle.BackColor = Legend.WorkerLegend.HasOffers;
                    continue;
                }
                else if (hasAssignedJobs)
                {
                    row.DefaultCellStyle.BackColor = Legend.WorkerLegend.HasAssignedJobs;
                    continue;
                }
                else
                {
                    switch (workerState)
                    {
                        case "active":
                            row.DefaultCellStyle.BackColor = Legend.WorkerLegend.Active;
                            break;

                        case "inactive":
                            row.DefaultCellStyle.BackColor = Legend.WorkerLegend.Inactive;
                            break;

                        case "draining":
                            row.DefaultCellStyle.BackColor = Legend.WorkerLegend.Draining;
                            break;
                    }
                }
            }
        }
        #endregion

        #region Jobs UI
        private async void btnCompleteJob_Click(object sender, EventArgs e)
        {
            List<string> jobIds = GetSelectedDataGridViewIds(dgJobs);

            if (jobIds.Count > 0)
            {
                foreach (var jobId in jobIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to complete job with Id '{jobId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        List<RouterJobAssignmentCustom> assignments = JsonConvert.DeserializeObject<List<RouterJobAssignmentCustom>>(_jobBindingList.First(j => j.Id == jobId).Assignments);

                        foreach (var assignment in assignments)
                        {
                            var response = await _routerClient.CompleteJobAsync(new CompleteJobOptions(jobId: jobId, assignmentId: assignment.AssignmentId));
                        }
                    }
                }
            }
        }

        private async void btnCloseJob_Click(object sender, EventArgs e)
        {
            List<string> jobIds = GetSelectedDataGridViewIds(dgJobs);

            if (jobIds.Count > 0)
            {
                foreach (var jobId in jobIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to close job with Id '{jobId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        List<RouterJobAssignmentCustom> assignments = JsonConvert.DeserializeObject<List<RouterJobAssignmentCustom>>(_jobBindingList.First(j => j.Id == jobId).Assignments);

                        foreach (var assignment in assignments)
                        {
                            var response = await _routerClient.CloseJobAsync(new CloseJobOptions(jobId: jobId, assignmentId: assignment.AssignmentId));
                        }
                    }
                }
            }
        }

        private async void btnCancelJob_Click(object sender, EventArgs e)
        {
            List<string> jobIds = GetSelectedDataGridViewIds(dgJobs);

            if (jobIds.Count > 0)
            {
                foreach (var jobId in jobIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to cancel job with Id '{jobId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var response = await _routerClient.CancelJobAsync(new CancelJobOptions(jobId));
                    }
                }
            }
        }

        private async void btnDeleteJob_Click(object sender, EventArgs e)
        {
            List<string> jobIds = GetSelectedDataGridViewIds(dgJobs);

            if (jobIds.Count > 0)
            {
                foreach (var jobId in jobIds)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete job with Id '{jobId}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var response = await _routerClient.DeleteJobAsync(jobId: jobId);

                        if (response.IsError == false)
                        {
                            RemoveJobBinding(jobId);
                        }
                    }
                }
            }
        }

        private async void btnCreateJob_Click(object sender, EventArgs e)
        {
            List<string> channelsIdList = GetUniqueWorkersChannels().Select(c => c.ChannelId).ToList();
            List<string> queuesId = GetQueuesIds();

            frmUpsertJob frmAddJob = new frmUpsertJob(false, channelsIdList, queuesId);

            if (frmAddJob.ShowDialog() == DialogResult.OK)
            {
                RouterJob routerJob = frmAddJob.Job;

                CreateJobOptions createJobOptions = new CreateJobOptions(routerJob.Id, routerJob.ChannelId, routerJob.QueueId)
                {
                    Priority = routerJob.Priority,
                    MatchingMode = routerJob.MatchingMode,
                };

                foreach (var selector in routerJob.RequestedWorkerSelectors)
                {
                    createJobOptions.RequestedWorkerSelectors.Add(selector);
                }

                foreach (var note in routerJob.Notes)
                {
                    createJobOptions.Notes.Add(note);
                }

                routerJob = await _routerClient.CreateJobAsync(createJobOptions);

                AddJobBinding(routerJob);
            }
        }

        private async void btnUpdateJob_Click(object sender, EventArgs e)
        {
            List<string> jobIds = GetSelectedDataGridViewIds(dgJobs);

            if (jobIds.Count == 1)
            {
                List<string> channelsIdList = GetUniqueWorkersChannels().Select(c => c.ChannelId).ToList();
                List<string> queuesId = GetQueuesIds();

                RouterJob routerJob = await _routerClient.GetJobAsync(jobIds.First());

                frmUpsertJob frmUpdateJob = new frmUpsertJob(true, channelsIdList, queuesId, routerJob);

                if (frmUpdateJob.ShowDialog() == DialogResult.OK)
                {
                    routerJob = frmUpdateJob.Job;

                    routerJob = await _routerClient.UpdateJobAsync(routerJob);
                }
            }
            else if (jobIds.Count == 0)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please select a single job. Cannot update multiple jobs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //WriteTrace("JOB: Data binding complete");

            foreach (DataGridViewRow row in dgJobs.Rows)
            {
                string jobStatus = row.Cells[DgJobsColumnIndex.Status].Value.ToString().ToLower();


                //created --> queued --> assign --> completed --> closed
                if (jobStatus == RouterJobStatus.Assigned)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Assigned;
                }
                else if (jobStatus == RouterJobStatus.Cancelled)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Cancelled;
                }
                else if (jobStatus == RouterJobStatus.ClassificationFailed)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.ClassificationFailed;
                }
                else if (jobStatus == RouterJobStatus.Closed)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Closed;
                }
                else if (jobStatus == RouterJobStatus.Completed)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Completed;
                }
                else if (jobStatus == RouterJobStatus.Created)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Created;
                }
                else if (jobStatus == RouterJobStatus.PendingClassification)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.PendingClassification;
                }
                else if (jobStatus == RouterJobStatus.PendingSchedule)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.PendingSchedule;
                }
                else if (jobStatus == RouterJobStatus.Queued)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Queued;
                }
                else if (jobStatus == RouterJobStatus.Scheduled)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.Scheduled;
                }
                else if (jobStatus == RouterJobStatus.ScheduleFailed)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.ScheduledFailed;
                }
                else if (jobStatus == RouterJobStatus.WaitingForActivation)
                {
                    row.DefaultCellStyle.BackColor = Legend.JobLegend.WaitingForActivation;
                }
            }
        }
        #endregion

        #region Menu strip
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void legendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLegend frmLegend = new frmLegend();

            frmLegend.Show();
        }
        #endregion
    }
}
