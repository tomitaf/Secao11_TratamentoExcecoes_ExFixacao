using System;
using System.Text;
using Secao11_TratamentoExcecoes.Entities.Exceptions;


namespace Secao11_TratamentoExcecoes.Entities
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("CheckOut < CheckIn");
            }
            if (checkOut < DateTime.Now || checkIn < DateTime.Now)
            {
                throw new DomainException("Datas invalidas");
            }

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("CheckOut < CheckIn");
            }
            if (checkOut < DateTime.Now || checkIn < DateTime.Now)
            {
                throw new DomainException("Datas invalidas");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reserva: ");
            sb.Append("Quarto " + NumeroQuarto);
            sb.Append(", Check In: " + CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(", Check Out: " + CheckOut.ToString("dd/MM/yyyy"));
            sb.Append(", " + Duracao() + " noite(s)");
            return sb.ToString();
        }
    }
}
