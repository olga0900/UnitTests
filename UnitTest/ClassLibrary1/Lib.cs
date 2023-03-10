namespace ClassLibrary1
{
    public class Lib
    {

        public decimal cours;
        public Lib (decimal kurs) 
        {
            cours = kurs;
        }
        public decimal Mult (decimal money) => money * cours;

        public bool Valid (object money) => decimal.TryParse(money.ToString(), out decimal n);

        public decimal Diff8 (decimal money)
        {
            var value = money * cours;
            if(money<500)
            {
                return (value - 8);
            }
            return 0;
            
        }
        public decimal DiffProc (decimal money, decimal proc)
        {
            var value = money * cours;
            if (money >= 500)
            { return value - (value * proc / 100); }
            return 0;
        }
        
        
            

    }
}