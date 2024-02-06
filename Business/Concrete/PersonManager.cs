using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak class kalmasın kuralı
    public class PersonManager :IApplicantService
    {
        
        //Encapsulation
        public void ApplyForMask(Person person)
        {

        }
        
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //Mernis kontrolü
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
