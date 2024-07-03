namespace Se130WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {

                    Console.WriteLine($"Worker running at: {DateTimeOffset.Now}");

                    await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eception occured: {ex.Message}");
            }
        }
    }
}
