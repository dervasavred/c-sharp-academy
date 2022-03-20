namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // NEED TO INITIALIZE VARS BEFORE USE, THE FOLLOWING LINE WILL FAIL
            //byte number;
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f; // WITHOUT THE f SUFFIX, C# CREATES THIS AS A double TYPE
            char character = 'A';
            string firstName = "Bob";
            bool isWorking = true;
            const float Pi = 3.14f;

            // var KEYWORD WILL AUTO-ASSIGN VARIABLE TYPE BASED ON DATA STORED
            var number2 = 3; // int32
            var lastName = "Smith"; // string
            var notWorking = false; // boolean

            // CW TAB TAB FOR SHORTCUT
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // FORMANT STRINGS
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // IMPLICIT TYPE CONVERSION
            byte b = 1; // 00000001 byte data type is 1 byte (duh) in size (0-255)
            int i = b;  // 00000000 00000000 0000000 00000001 int is 4 bytes, so b can fit in i but not vice-versa and will fail to compile

            // EXPLICIT CONVERSION
            int j = 2;
            byte c = (byte)j; // FORCES CONVERSION OF DATA TYPE REGARDLESS OF DATA LOSS. THIS _WILL_ COMPILE BUT YOU WILL LOSE INFO/PRECISION

            int k = 3;
            float f = k; // NO ISSUES HERE

            float g = 1.2f;
            // l = g; // FAILS COMPILE
            int l = (int)g; // DROPS THE .2 FROM THE FLOAT

            // INCOMPATIBLE TYPES
            string s = "1";
            //int m = s; // FAILS COMPILE, STRING CANNOT BE CAST LIKE THIS
            //int m = (int)s; // FAILS TOO, DATA TYPES ARE NOT COMPATIBLE
            int m = Convert.ToInt32(s);
            // OR
            int n = int.Parse(s);

            // ERROR HANDLING WITH TRY-CATCH
            try
            {
                var y = "1234"; // string TYPE AUTO-ASSIGNED
                byte z = Convert.ToByte(y); // WILL FAIL DUE TO byte TYPE INCOMPATIBLE WITH string TYPE
                Console.WriteLine(z);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to type: byte.");
            }


            // OPERATORS
            // INCREMENT OPERATORS
            int a = 1;
            int b = a++; // POSTFIX INCREMENT. b IS ASSIGNED 1, THEN a IS INCREMENTED. b ASSIGNED a, a INCREMENTED TO 2.
            int c = ++a; // PREFIX INCREMENT. a IS INCREMENTED, THEN c IS ASSIGNED a. a INCREMENTED TO 3, c ASSIGNED 3. 
        }
    }
}