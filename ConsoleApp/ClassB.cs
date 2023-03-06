namespace ConsoleApp
{
    internal class ClassB : InterfaceB
    {
        private InterfaceC _c;
        public ClassB(InterfaceC c)
        {
            _c = c;
        }

        public void DoAction()
        {
            Console.WriteLine("ClassB");
            _c.DoAction();
        }
    }
}
