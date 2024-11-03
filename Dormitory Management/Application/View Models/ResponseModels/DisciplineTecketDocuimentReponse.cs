using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class DisciplineTecketDocuimentReponse
    {

        public int OrderIndex { get; set; }

        public int? DocumentTypeId { get; set; }

        public string? FileLink { get; set; }
    }
}
