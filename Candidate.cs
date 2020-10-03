using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Candidate
    {
        public Guid id{ get; private set; }
        public string name { get; private set; }
        public string cpf { get; private set; }
        public int votes { get; private set; }

        public Candidate(string name, string cpf)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.cpf = cpf;
            this.votes = 0;
        }

        public void Vote()
        {
            votes++;
        }
    }
    

}