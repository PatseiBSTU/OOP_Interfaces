namespace Interfaces
{
    class Program
    {
        static void DoWork (IPosebel some)
        {
            some.WrigthCode();
        }
        static void Main(string[] args)
        {
            Student poitStudent = new Student();
            poitStudent.Sleep();
            poitStudent.WrigthCode();

            IPosebel isitStudent = new Student();
            isitStudent.Jump(56);
            isitStudent.Math();
            isitStudent.Go();

            IPosebel professor = new Philosopher();
            professor.Go();
            professor.Math();

            DoWork(professor);
            DoWork(isitStudent);

        }
    }
}
