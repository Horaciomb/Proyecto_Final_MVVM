namespace AppPhone.Models
{
    class AppModel
    {
          
            public int PersonID { get; set; }

            
            public string First_Name { get; set; }

            
            public string Last_Name { get; set; }

          
            public BloodType Type_B { get; set; }


        }

        public enum BloodType
        {
            A_Pos,
            A_Neg,
            B_Pos,
            B_Neg,
            AB,
            O,

        }
}
