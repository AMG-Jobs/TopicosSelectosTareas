using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFConversor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConversor
    {

        [OperationContract]
        string GetData(int value);

        //pulgadas centimetros-cescius farenheit
        [OperationContract]
        double CorvertirCentimetrosAPulgadas(double centimetros);

        [OperationContract]
        double CorvertirPulgadasACentimetros(double pulgadas);

        [OperationContract]
        double CorvertirCelsiusAFarenheit(double celsius);

        [OperationContract]
        double CorvertirFarenheitACelsius(double farenheit);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
