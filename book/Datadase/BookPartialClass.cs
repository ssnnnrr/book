using book.Classes;
using System.Linq;
using System.Windows.Media;
using System;

namespace book.Datadase
{
    public partial class Book
    {
        public SolidColorBrush DiscountColor
        {
            get
            {
                var maxDiscount = Classes.DBConnectionClass.DatabaseConnection.MaxDiscount.Where(c => c.MaxDiscountId == MaxDiscountId).First();

                if (maxDiscount == null)
                    return Brushes.Transparent;

                if (maxDiscount.Value >= 15)
                    return Brushes.Chartreuse;
                else if (maxDiscount.Value >= 10)
                    return Brushes.Yellow;
                else if (maxDiscount.Value >= 5)
                    return Brushes.Orange;
                else
                    return Brushes.Transparent;
            }
        }
        public string NewPrice
        {
            get
            {
                if (ActiveDiscountId != null)
                {
                    string a = Convert.ToString(Price - (Price / 100 * DBConnectionClass.DatabaseConnection.ActiveDiscount.Where(c => c.ActiveDiscountId == ActiveDiscountId).First().Value));
                    return "\t" + a;
                }
                else return null;
            }
        }
    }
}