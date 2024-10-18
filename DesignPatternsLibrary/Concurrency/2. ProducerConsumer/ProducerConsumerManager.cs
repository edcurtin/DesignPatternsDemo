using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Concurrency._2._ProducerConsumer
{
    public class ProducerConsumerManager
    {
        private BlockingCollection<int> _blockingCollection;
        private int _producerCount;
        private int _consumerCount;

        public ProducerConsumerManager(int boundedCapacity = 5)
        {
            _blockingCollection = new BlockingCollection<int>(boundedCapacity);
        }

        public async Task StartProcessing(int producerCount, int consumerCount)
        {
            _producerCount = producerCount;
            _consumerCount = consumerCount;

            var producerTasks = new Task[producerCount];
            var consumerTasks = new Task[consumerCount];

            // Start producer tasks
            for (int i = 0; i < producerCount; i++)
            {
                int producerId = i + 1;
                producerTasks[i] = Task.Run(() => Producer(producerId));
            }

            // Start consumer tasks
            for (int i = 0; i < consumerCount; i++)
            {
                int consumerId = i + 1;
                consumerTasks[i] = Task.Run(() => Consumer(consumerId));
            }

            // Wait for all producers to finish
            await Task.WhenAll(producerTasks);

            // Signal completion of adding items
            _blockingCollection.CompleteAdding();

            // Wait for all consumers to finish processing
            await Task.WhenAll(consumerTasks);

            Console.WriteLine("All producers and consumers have finished processing.");
        }

        private void Producer(int producerId)
        {
            for (int i = 0; i < 10; i++)
            {
                // Simulate time to produce an item
                Thread.Sleep(new Random().Next(500, 1000));

                Console.WriteLine($"Producer {producerId} produced item {i}");
                _blockingCollection.Add(i);
            }
        }

        private void Consumer(int consumerId)
        {
            foreach (var item in _blockingCollection.GetConsumingEnumerable())
            {
                Console.WriteLine($"Consumer {consumerId} consumed item {item}");

                // Simulate time to process an item
                Thread.Sleep(new Random().Next(500, 1000));
            }
        }
    }
}
