using Course.Entities.Enums;
using System.Collections.Generic;


namespace Course.Entities {
    class Worker  {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Contract> Contract { get; set; } = new List<Contract>();
        // Instanciar de agora, para garantir que a lista não seja vazia

        public Worker() {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // Não colocar no construtor o Contracts, pois não é usual passar uma lista instanciada em construtor
            // Não incluir uma associação 'para muitos' num construtor
            // Ela inicia vazia, e de acordo com necessidade, vai adicionando
        }

        public void AddContract (Contract contract){
            Contract.Add(contract);
            // Adiciona à lista, quando chamado o método AddContract, o contrato que chega como parâmetro
        }

        public void RemoveContract(Contract contract) {
            Contract.Remove(contract);

        }

        public double Income (int year, int month) {
            double sum = BaseSalary;

            foreach (Contract contracts in Contract ) {
                if (contracts.Date.Year == year && contracts.Date.Month == month) {
                    sum = sum + contracts.TotalValue();
                }
            }

            return sum;
        }


    }

}
