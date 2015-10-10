using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VerificaDocumento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VerificaDocumento.svc or VerificaDocumento.svc.cs at the Solution Explorer and start debugging.
    public class VerificaDocumento : IVerificaDocumento
    {
        public bool VerificaRUC(string identificationDocument)
        {
            if (!string.IsNullOrEmpty(identificationDocument))
            {
                int addition = 0;
                int[] hash = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                int identificationDocumentLength = identificationDocument.Length;

                string identificationComponent = identificationDocument.Substring(0, identificationDocumentLength - 1);

                int identificationComponentLength = identificationComponent.Length;

                int diff = hash.Length - identificationComponentLength;

                for (int i = identificationComponentLength - 1; i >= 0; i--)
                {
                    addition += (identificationComponent[i] - '0') * hash[i + diff];
                }

                addition = 11 - (addition % 11);

                if (addition == 11)
                {
                    addition = 0;
                }

                char last = char.ToUpperInvariant(identificationDocument[identificationDocumentLength - 1]);

                if (identificationDocumentLength == 11)
                {
                    // The identification document corresponds to a RUC.
                    return addition.Equals(last - '0');
                }
                else if (char.IsDigit(last))
                {
                    // The identification document corresponds to a DNI with a number as verification digit.
                    char[] hashNumbers = { '6', '7', '8', '9', '0', '1', '1', '2', '3', '4', '5' };
                    return last.Equals(hashNumbers[addition]);
                }
                else if (char.IsLetter(last))
                {
                    // The identification document corresponds to a DNI with a letter as verification digit.
                    char[] hashLetters = { 'K', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
                    return last.Equals(hashLetters[addition]);
                }
            }
            return false;
        }
    }
}
