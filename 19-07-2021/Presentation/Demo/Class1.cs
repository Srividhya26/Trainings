using System;
using System.Text;

namespace Demo
{
    public class Class1
    {


        StringBuilder text = new StringBuilder("This is some sample text");
        
        public string Find()
        {
            string sb = text.ToString();
            if (sb.Contains("sample text")) 
            {
                return "sample text is present in the given text";
            }
            else
            {
                throw new Exception("The text is not found");
            }
        }

    }
}
