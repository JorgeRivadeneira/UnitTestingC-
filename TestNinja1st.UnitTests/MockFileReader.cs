using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja1st.UnitTests
{
    public class MockFileReader : IFileReader
    {
        string IFileReader.Read(string path)
        {
            return "";
        }
    }
}
