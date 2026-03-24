// ============================================================
//  Program.cs — Guide #10 Demo
//
//  The Program class is the entry point of every WinForms app.
//  Main() calls Application.Run() and passes in a NEW INSTANCE
//  of the startup form:
//
//      Application.Run(new OrderForm());   ← correct
//      Application.Run(OrderForm);         ← WRONG — no "new"
//
//  To change the startup form, swap "new OrderForm()" for
//  another form name, e.g. "new LoginForm()".
// ============================================================

namespace PizzaOrderApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new OrderForm());   // startup form
        }
    }
}
