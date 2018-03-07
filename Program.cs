using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> payroll = new List<Employee>();
            StreamReader sr = new StreamReader(".\\employees.txt");
            string[] line = sr.ReadLine().Split(',');

            while(line != null)
            {
                payroll.Add(new Employee(line[0], line[1], line[2], line[3], float.Parse(line[4]), line[5], line[6], int.Parse(line[7])));
                if(payroll.Count < 1000000)
                {
                    line = sr.ReadLine().Split(',');
                }
                else
                {
                    line = null;
                }
            }

            CalculatePayroll(payroll);
            Console.Write("Enter an employee's id to search: ");
            string id = Console.ReadLine();
            int places = id.Length;
            int employeeid = 0;

            switch(places)
            {
                case 1:
                    employeeid = Amount(id[0]);
                    break;
                case 2:
                    employeeid = Amount(id[0]) * 36 + Amount(id[1]);
                    break;
                case 3:
                    employeeid = Amount(id[0]) * 36 * 36 + Amount(id[1]) * 36 + Amount(id[2]);
                    break;
                case 4:
                    employeeid = Amount(id[0]) * 36 * 36 * 36 + Amount(id[1]) * 36 * 36 + Amount(id[2]) * 36 + Amount(id[3]);
                    break;
            }

            Console.WriteLine(payroll[employeeid - 1].ToString());
   

            Console.ReadKey();
        }

        static int Amount(char temp)
        {
            switch(temp)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case 'A': return 10;
                case 'B': return 11;
                case 'C': return 12;
                case 'D': return 13;
                case 'E': return 14;
                case 'F': return 15;
                case 'G': return 16;
                case 'H': return 17;
                case 'I': return 18;
                case 'J': return 19;
                case 'K': return 20;
                case 'L': return 21;
                case 'M': return 22;
                case 'N': return 23;
                case 'O': return 24;
                case 'P': return 25;
                case 'Q': return 26;
                case 'R': return 27;
                case 'S': return 28;
                case 'T': return 29;
                case 'U': return 30;
                case 'V': return 31;
                case 'W': return 32;
                case 'X': return 33;
                case 'Y': return 34;
                case 'Z': return 35;
            }

            return -1;
        }

        static void StateStatistics(List<Paycheck> pay)
        {
            List<int> utahhours = new List<int>();
            List<int> wyominghours = new List<int>();
            List<int> nevadahours = new List<int>();
            List<int> coloradohours = new List<int>();
            List<int> idahohours = new List<int>();
            List<int> arizonahours = new List<int>();
            List<int> oregonhours = new List<int>();
            List<int> washingtonhours = new List<int>();
            List<int> newmexicohours = new List<int>();
            List<int> texashours = new List<int>();

            List<float> utahnetpay = new List<float>();
            List<float> wyomingnetpay = new List<float>();
            List<float> nevadanetpay = new List<float>();
            List<float> coloradonetpay = new List<float>();
            List<float> idahonetpay = new List<float>();
            List<float> arizonanetpay = new List<float>();
            List<float> oregonnetpay = new List<float>();
            List<float> washingtonnetpay = new List<float>();
            List<float> newmexiconetpay = new List<float>();
            List<float> texasnetpay = new List<float>();

            float totalutahstatetaxes = 0;
            float totalwyomingstatetaxes = 0;
            float totalnevadastatetaxes = 0;
            float totalcoloradostatetaxes = 0;
            float totalidahostatetaxes = 0;
            float totalarizonastatetaxes = 0;
            float totaloregonstatetaxes = 0;
            float totalwashingtonstatetaxes = 0;
            float totalnewmexicostatetaxes = 0;
            float totaltexasstatetaxes = 0;

            for (int i = 0; i < pay.Count; i++)
            {
                if(pay[i].state.Equals("UT"))
                {
                    utahhours.Add(pay[i].hours);
                    utahnetpay.Add(pay[i].netpay);
                    totalutahstatetaxes += pay[i].statetax;
                }
                else if(pay[i].state.Equals("WY"))
                {
                    wyominghours.Add(pay[i].hours);
                    wyomingnetpay.Add(pay[i].netpay);
                    totalwyomingstatetaxes += pay[i].statetax;
                }
                else if(pay[i].state.Equals("NV"))
                {
                    nevadahours.Add(pay[i].hours);
                    nevadanetpay.Add(pay[i].netpay);
                    totalnevadastatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("CO"))
                {
                    coloradohours.Add(pay[i].hours);
                    coloradonetpay.Add(pay[i].netpay);
                    totalcoloradostatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("ID"))
                {
                    idahohours.Add(pay[i].hours);
                    idahonetpay.Add(pay[i].netpay);
                    totalidahostatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("AZ"))
                {
                    arizonahours.Add(pay[i].hours);
                    arizonanetpay.Add(pay[i].netpay);
                    totalarizonastatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("OR"))
                {
                    oregonhours.Add(pay[i].hours);
                    oregonnetpay.Add(pay[i].netpay);
                    totaloregonstatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("WA"))
                {
                    washingtonhours.Add(pay[i].hours);
                    washingtonnetpay.Add(pay[i].netpay);
                    totalwashingtonstatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("NM"))
                {
                    newmexicohours.Add(pay[i].hours);
                    newmexiconetpay.Add(pay[i].netpay);
                    totalnewmexicostatetaxes += pay[i].statetax;
                }
                else if (pay[i].state.Equals("TX"))
                {
                    texashours.Add(pay[i].hours);
                    texasnetpay.Add(pay[i].netpay);
                    totaltexasstatetaxes += pay[i].statetax;
                }
            }

            List<StateStats> states = new List<StateStats>();

            float utahmediannetpay = CalculateMedian(utahnetpay);
            float utahmedianhours = CalculateMedian(utahhours);
            states.Add(new StateStats("UT", utahmedianhours, utahmediannetpay, totalutahstatetaxes));

            float wyomingmediannetpay = CalculateMedian(wyomingnetpay);
            float wyomingmedianhours = CalculateMedian(wyominghours);
            states.Add(new StateStats("WY", wyomingmedianhours, wyomingmediannetpay, totalwyomingstatetaxes));

            float nevadamediannetpay = CalculateMedian(nevadanetpay);
            float nevadamedianhours = CalculateMedian(nevadahours);
            states.Add(new StateStats("NV", nevadamedianhours, nevadamediannetpay, totalnevadastatetaxes));

            float coloradomediannetpay = CalculateMedian(coloradonetpay);
            float coloradomedianhours = CalculateMedian(coloradohours);
            states.Add(new StateStats("CO", coloradomedianhours, coloradomediannetpay, totalcoloradostatetaxes));

            float idahomediannetpay = CalculateMedian(idahonetpay);
            float idahomedianhours = CalculateMedian(idahohours);
            states.Add(new StateStats("ID", idahomedianhours, idahomediannetpay, totalidahostatetaxes));

            float arizonamediannetpay = CalculateMedian(arizonanetpay);
            float arizonamedianhours = CalculateMedian(arizonahours);
            states.Add(new StateStats("AZ", arizonamedianhours, arizonamediannetpay, totalarizonastatetaxes));

            float oregonmediannetpay = CalculateMedian(oregonnetpay);
            float oregonmedianhours = CalculateMedian(oregonhours);
            states.Add(new StateStats("OR", oregonmedianhours, oregonmediannetpay, totaloregonstatetaxes));

            float washingtonmediannetpay = CalculateMedian(washingtonnetpay);
            float washingtonmedianhours = CalculateMedian(washingtonhours);
            states.Add(new StateStats("WA", washingtonmedianhours, washingtonmediannetpay, totalwashingtonstatetaxes));

            float newmexicomediannetpay = CalculateMedian(newmexiconetpay);
            float newmexicomedianhours = CalculateMedian(newmexicohours);
            states.Add(new StateStats("NM", newmexicomedianhours, newmexicomediannetpay, totalnewmexicostatetaxes));

            float texasmediannetpay = CalculateMedian(texasnetpay);
            float texasmedianhours = CalculateMedian(texashours);
            states.Add(new StateStats("TX", texasmedianhours, texasmediannetpay, totaltexasstatetaxes));

            states.Sort((p, q) => p.name.CompareTo(q.name));

            using (StreamWriter sw = new StreamWriter(".\\employees3.txt"))
            {
                for (int i = 0; i < states.Count; i++)
                {
                    sw.WriteLine(states[i].ToString());
                }
            }
        }

        public static float CalculateMedian(List<int> temp)
        {
            temp.Sort((a, b) => a.CompareTo(b));
            int length = temp.Count;

            if(length % 2 == 1)
            {
                return (float)temp[(length - 1) / 2];
            }
            else
            {
                return (temp[length / 2] + temp[(length / 2) - 1]) / 2.0f;
            }
        }

        public static float CalculateMedian(List<float> temp)
        {
            int length = temp.Count;
            
            temp.Sort((a, b) => a.CompareTo(b));
            if(length % 2 == 1)
            {
                return temp[(length - 1) / 2];
            }
            else
            {
                float medianadd = temp[length / 2 - 1] + temp[length / 2];
                float median = medianadd / 2;

                return median;
            }
        }

        static void TopEarners(List<Employee> payroll, List<Paycheck> pay)
        {
            List<TopEarners> top = new List<TopEarners>();
            int numyears = 0;

            for(int i = 0; i < pay.Count * .15; i++)
            {
                string date = payroll[i].date;
                int lastindexof = date.LastIndexOf("/");
                int year = Int32.Parse(date.Substring(lastindexof + 1, 2));
                if(year > 18)
                {
                    numyears = 118 - year;
                }
                else
                {
                    numyears = 18 - year;
                }

                top.Add(new TopEarners(pay[i].firstname, pay[i].lastname, numyears, pay[i].grosspay));
            }

            List<TopEarners> top2 = top.OrderByDescending(x => x.yearsworked).ThenBy(x => x.lastname).ThenBy(x => x.firstname).ToList();

            using (StreamWriter sw = new StreamWriter(".\\employees2.txt"))
            {
                for (int i = 0; i < top2.Count; i++)
                {
                    sw.WriteLine(top2[i].ToString());
                }
            }
        }

        static float CalculateNetPay(float grosspay, float federaltax, float statetax)
        {
            return grosspay - federaltax - statetax;
        }

        static float CalculateStateTax(float grosspay, string state)
        {
            if (state.Equals("UT") || state.Equals("WY") || state.Equals("NV"))
            {
                return grosspay * .05f;
            }
            else if(state.Equals("CO") || state.Equals("ID") || state.Equals("AZ") || state.Equals("OR"))
            {
                return grosspay * .065f;
            }
            else if (state.Equals("WA") || state.Equals("NM") || state.Equals("TX"))
            {
                return grosspay * .07f;
            }

            return 0;
        }

        static float CalculateFederalTax(float grosspay)
        {
            return grosspay * .15f;
        }

        static void CalculatePayroll(List<Employee> payroll)
        {
            List<Paycheck> pay = new List<Paycheck>();
            float grosspay;
            float federaltax;
            float statetax;
            float netpay;

            for (int i = 0; i < payroll.Count; i++)
            {
                if (payroll[i].paytype.Equals("H"))
                {
                    grosspay = 0;
                    federaltax = 0;
                    statetax = 0;
                    netpay = 0;
                    int temp = 0;
                    if (payroll[i].hours <= 80)
                    {
                        grosspay = payroll[i].pay * payroll[i].hours;
                        federaltax = CalculateFederalTax(grosspay);
                        statetax = CalculateStateTax(grosspay, payroll[i].state);
                        netpay = CalculateNetPay(grosspay, federaltax, statetax);
                    }
                    else if (payroll[i].hours > 80 && payroll[i].hours <= 90)
                    {
                        temp = payroll[i].hours - 80;
                        grosspay = payroll[i].pay * 80 + (payroll[i].pay * 1.5f) * temp;
                        federaltax = CalculateFederalTax(grosspay);
                        statetax = CalculateStateTax(grosspay, payroll[i].state);
                        netpay = CalculateNetPay(grosspay, federaltax, statetax);
                    }
                    else if (payroll[i].hours > 90)
                    {
                        temp = payroll[i].hours - 90;
                        grosspay = payroll[i].pay * 80 + (payroll[i].pay * 1.5f) * 10 + (payroll[i].pay * 1.75f) * temp;
                        federaltax = CalculateFederalTax(grosspay);
                        statetax = CalculateStateTax(grosspay, payroll[i].state);
                        netpay = CalculateNetPay(grosspay, federaltax, statetax);
                    }
                }
                else
                {
                    grosspay = payroll[i].pay / 26.0f;
                    federaltax = CalculateFederalTax(grosspay);
                    statetax = CalculateStateTax(grosspay, payroll[i].state);

                    netpay = grosspay - federaltax - statetax;
                }

                pay.Add(new Paycheck(payroll[i].id, payroll[i].firstname, payroll[i].lastname, grosspay, federaltax, statetax, netpay, payroll[i].state, payroll[i].hours));
            }

            pay.Sort((p, q) => q.grosspay.CompareTo(p.grosspay));

            using (StreamWriter sw = new StreamWriter(".\\employees1.txt"))
            {
                for (int i = 0; i < pay.Count; i++)
                {
                    sw.WriteLine(pay[i].ToString());
                }
            }

            TopEarners(payroll, pay);
            StateStatistics(pay);
        }
    }

    class StateStats
    {
        public string name;
        public float medianhoursworked;
        public float mediannetpay;
        public float totalstatetaxes;

        public StateStats(string name, float medianhoursworked, float mediannetpay, float totalstatetaxes)
        {
            this.name = name;
            this.medianhoursworked = medianhoursworked;
            this.mediannetpay = mediannetpay;
            this.totalstatetaxes = totalstatetaxes;
        }

        public override string ToString()
        {
            return name + "," + medianhoursworked + "," + mediannetpay.ToString("#.##") + "," + totalstatetaxes.ToString("#.##");
        }
    }

    class TopEarners
    {
        public string firstname;
        public string lastname;
        public int yearsworked;
        public float grosspay;

        public TopEarners(string firstname, string lastname, int yearsworked, float grosspay)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.yearsworked = yearsworked;
            this.grosspay = grosspay;
        }

        public override string ToString()
        {
            return firstname + "," + lastname + "," + yearsworked + "," + grosspay.ToString("#.##");
        }
    }

    class Paycheck
    {
        public string id;
        public string firstname;
        public string lastname;
        public float grosspay;
        public float federaltax;
        public float statetax;
        public float netpay;
        public string state;
        public int hours;

        public Paycheck(string id, string firstname, string lastname, float grosspay, float federaltax, float statetax, float netpay, string state, int hours)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.grosspay = grosspay;
            this.federaltax = federaltax;
            this.statetax = statetax;
            this.netpay = netpay;
            this.state = state;
            this.hours = hours;
        }

        public override string ToString()
        {
            return id + "," + firstname + "," + lastname + "," + grosspay.ToString("#.##") + "," + federaltax.ToString("#.##") + "," + statetax.ToString("#.##") + "," + netpay.ToString("#.##");
        }
    }

    class Employee
    {
        public string id;
        public string firstname;
        public string lastname;
        public string paytype;
        public float pay;
        public string date;
        public string state;
        public int hours;

        public Employee(string id, string firstname, string lastname, string paytype, float pay, string date, string state, int hours)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.paytype = paytype;
            this.pay = pay;
            this.date = date;
            this.state = state;
            this.hours = hours;
        }

        public override string ToString()
        {
            return id + "," + firstname + "," + lastname + "," + paytype + "," + pay + "," + date + "," + state + "," + hours;
        }
    }
}