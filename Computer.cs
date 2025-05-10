using System;

namespace ComputerApp
{
    public class Computer
    {
        
        private int inventoryNumber;
        private double processorFrequencyGHz;
        private int hardDriveSizeGB;


        public int InventoryNumber
        {
            get { return inventoryNumber; }
            set { inventoryNumber = value; }
        }

        public double ProcessorFrequencyGHz
        {
            get { return processorFrequencyGHz; }
            set { processorFrequencyGHz = value; }
        }

        public int HardDriveSizeGB
        {
            get { return hardDriveSizeGB; }
            set { hardDriveSizeGB = value; }
        }

        
        public Computer(int number, double frequency, int memory)
        {
            inventoryNumber = number;
            processorFrequencyGHz = frequency;
            hardDriveSizeGB = memory;
        }

        
        public void ShowInfo()
        {
            Console.WriteLine("Инвентарный номер: " + inventoryNumber);
            Console.WriteLine("Частота процессора: " + processorFrequencyGHz + " ГГц");
            Console.WriteLine("Объем жёсткого диска: " + hardDriveSizeGB + " ГБ");
        }

        
        public double CalculateMemoryCost(double costPerGB)
        {
            return hardDriveSizeGB * costPerGB;
        }
    }
}
