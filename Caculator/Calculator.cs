using System.Data;

namespace Caculator
{
    public static class Calculator
    {
      
        public static string DoCalculation(string eval)
        {
            DataTable dataTable = new DataTable();

            var result = "";

            try
            {
                result = dataTable.Compute(eval, "").ToString();
            }
            catch (Exception)
            {
                result = "Error";
               
            }
               

            return result.ToString();
        }
        
    }
}
