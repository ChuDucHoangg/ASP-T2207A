using System;
namespace Assignment6
{
	public class News : INews
	{
        public int ID { get; set; }
        public String Title { get; set; }
        public String PublishDate { get; set; }
        public String Author { get; set; }
        public String Content { get; set; }
        public float averageRate;
        public float AverageRate
        {
            get { return averageRate; }
        }

        public void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Average Rate: " + AverageRate);
        }

        int[] RateList = new int[3];

        public void Calculate(int[] RateList)
        {
            this.averageRate = (float)(RateList[0] + RateList[1] + RateList[2]) / 3;
        }
    }
}

