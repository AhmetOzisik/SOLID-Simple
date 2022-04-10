using System;
using System.Collections.Generic;
using System.Text;

namespace YtmVizeCözüm
{
    public class VeriTabani
    {
        private  IVeriTabanı veriTabanı=null;
        private static Object kilit = new Object();
        private static VeriTabani veritabani;
        public static VeriTabani veritabaniolustur()
        {
            if (veritabani == null)
            {
                lock (kilit)
                {
                    if (veritabani == null)
                    {
                        veritabani = new VeriTabani();
                                                   
                    }
                }
              

            }
            return veritabani;
        }
        public IVeriTabanı AsılVeriTabanı(IVeriTabanı _veriTabanı)
        {
            this.veriTabanı = _veriTabanı;
            return veriTabanı;
            
        }
       
        
        
    }
    
}
