
class Program
{
    static void Main()
    {
        Type t = Type.GetTypeFromProgID("KSR20.COM3Klasa.1");
        object k = Activator.CreateInstance(t);
        object[] args = new object[] { "Dziala OK" };
        t.InvokeMember("Test", System.Reflection.BindingFlags.InvokeMethod, null, k, args);
    }
}