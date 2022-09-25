namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDatabase sqldb = new SqlDatabase();
            sqldb.Update();
        }
    }

    abstract class Database //base,parent abstract ile soyutladık
                            //0D: Dependency Inversion aşağı yöne genişlesin demek
    {
        public void Add()
        {
            Console.WriteLine("Added by database. ");
        }
        public virtual void Update() //bu metod override edilebilir (yani ezilebilir)
        {
            Console.WriteLine("Updated by database. ");
        }
    }
    class SqlDatabase : Database
    {
        public override void Update()
        {
            Console.WriteLine("Updated by sql database. ");
            base.Update();
        }
    }
    class OracleDatabase : Database
    {
        public override void Update()
        {
            Console.WriteLine("Updated by oracle database. ");
            base.Update();
        }
    }
}
//bu projede virtual ethod öğrendik yani kalıtımda bi önceki kalıtımı değiştirebilmek
//için kullanıyoruz virtual yaptığımız method daha sonraki classda override
//ile değiştirilebilir

//ayrıca abstract class ile clası newlemeyi öğreniyoruz
//    sadece classın başına abstract yazıoyruz bitiyor