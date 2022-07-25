using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.SharedLibrary.DTOs
{
    public class ErrorDTO
    {
        public List<String> Errors { get; set; }

        // Is error visible to client?
        public bool IsVisible { get; set; }

        public ErrorDTO()
        {
            Errors = new List<String>();
        }

        public ErrorDTO(string error, bool IsVisible)
        {
            Errors.Add(error);
            this.IsVisible = IsVisible;
        }

        public ErrorDTO(List<String> Errors, bool IsVisible)
        {
            this.Errors=Errors;
            this.IsVisible = IsVisible;
        }
    }
}
