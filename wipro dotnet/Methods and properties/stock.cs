using System;

namespace myapp
{
    class stock
    {
        string stock_name;
        string stock_symbol;
        double previous_closing_price;
        double current_closing_price;
        double percentage_change;
        stock(string stock_name,string stock_symbol,double previous_closing_price,double current_closing_price)
        {
            this.stock_name=stock_name;
            this.stock_symbol=stock_symbol;
            this.previous_closing_price=previous_closing_price;
            this.current_closing_price=current_closing_price;
        }
        public double getChangePercentage()
        {
            
            if(previous_closing_price>current_closing_price)
            {
                percentage_change=((previous_closing_price-current_closing_price)/previous_closing_price)*100;
            }
            else
            {
                percentage_change=((current_closing_price-previous_closing_price)/previous_closing_price)*100;
            }
            return percentage_change;
        }
       
        static void Main(string[] args)
        {
            string stock_name=Console.ReadLine();
        string stock_symbol=Console.ReadLine();
        double previous_closing_price=Convert.ToDouble(Console.ReadLine());
        double current_closing_price=Convert.ToDouble(Console.ReadLine());
            stock s=new stock(stock_name,stock_symbol,previous_closing_price,current_closing_price);
           double d=s.getChangePercentage();
            Console.WriteLine(d);
        }

        

    }
}
