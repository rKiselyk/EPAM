using System;
using System.Reflection;
using AdditionClasses;

namespace Lab5Lib {
    public class PrintInfo {
        public static void PrintInfoAssembly(IPrinter consolePrinter) {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()) {
                consolePrinter.WriteLine(assembly.ToString());
                foreach (Module modul in assembly.GetModules(true)) {
                    consolePrinter.WriteLine("\t" + modul.ToString());
                }
                foreach (Type type in assembly.GetExportedTypes()) {
                    consolePrinter.WriteLine("\t\t" + type.ToString());
                    foreach (MemberInfo memberInf in type.GetMembers()) {
                        consolePrinter.WriteLine("\t\t\t" + memberInf.ToString());
                        if (memberInf.MemberType == MemberTypes.Method) {
                            foreach (ParameterInfo parameterInfo in ((MethodInfo)memberInf).GetParameters()) {
                                consolePrinter.WriteLine("\t\t\t\t" + parameterInfo.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
