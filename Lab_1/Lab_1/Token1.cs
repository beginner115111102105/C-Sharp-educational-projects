using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Token1 
    {
        private string group;
        private int start;
        private int end;
        public Token1(string group, int start, int end)
        {
            this.group = group;
            this.start = start;
            this.end = end;
        }

        public int GetStart()
        { return this.start; }
        public int GetEnd()
        { return this.end; }
        public string GetGroup()
        { return this.group; }
        public void SetStart(int start)
        { this.start = start; }
        public void SetEnd(int end)
        { this.end = end; }
        public void SetGroup(string group)
        { this.group = group; }

    }
    
}
