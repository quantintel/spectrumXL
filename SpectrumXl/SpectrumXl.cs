/*
 * Copyright (c) 2014  Paul Bernard
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Spectrum Finance is based in part on:
 *        QuantLib. http://quantlib.org/
 *
 */

using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Api;
using Org.Quantintel.Spectrum.Model;
using ExcelDna.Integration.CustomUI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace SpectrumXl
{
    
    [ComVisible(true)]
    public class QuantIntelRibbon : ExcelRibbon
    {

        public static Form configForm = new ConfigurationDialog();

        public void ServiceConfig(IRibbonControl control)
        {
            configForm.Show();
        }
    }

    public class SpectrumXl
    {
      


    }
}
