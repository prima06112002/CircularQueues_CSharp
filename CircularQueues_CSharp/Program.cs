using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /*Initializing the values of the variabels REAR and FRONT to -1 
             * to indicate that the queue is initially empty. */
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /* This statement checks for the overlow condition. */
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overlow\n");
                return;
            }
            /* The following statement checks whether the queue is empty.if the
             * queue is empty the value of the REAR and FRONT variable is set to 0.*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last position of the array,then the value
                 * of REAR is set to 0 that corresponds to the first position of the array */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at the last position then its value is 
                     * incremented by one. */
                    REAR = REAR + 1;

            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /* Checks whether the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");
            /* Checks if the queue has one element */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* Checks if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElement is the queue are.............\n");
            if (FRONT_position <= REAR_position)
            {
                /* Traverse the queue till the last element present in an array. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* Traverse the queue till the last position of the array. */
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                /* Set the FRONT position to the first element of the array. */
                FRONT_position = 0;
                /* Traverse the array till the last element present in the queue. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter Your Choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }
    }
}