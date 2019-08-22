﻿using netDxf;
using netDxf.Entities;
using netDxf.Header;
using netDxf.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxf_creating_description_for_nesting.Entity
{
    class DxfWriter
    {
        // dxf filename
        private string[] filesPath;

        // text
        private Vector3 textLocation = new Vector3(0, 0, 0);
        private Text text;

        // by default it will create an AutoCad2000 DXF version
        private DxfDocument dxfDocument;

        public void writeDxf()
        {
            bool isBinary;
            foreach (string file in filesPath)
            {

                // this check is optional but recommended before loading a DXF file
                DxfVersion dxfVersion = DxfDocument.CheckDxfFileVersion(file, out isBinary);
                // netDxf is only compatible with AutoCad2000 and higher DXF version
                if (dxfVersion < DxfVersion.AutoCad2000) return;
                // load file
                dxfDocument = DxfDocument.Load(file);

                // text
                text = new Text("Test text", textLocation, 5.0);
                Layer layer = new Layer("8");
                text.Layer = layer;
                text.Alignment = TextAlignment.BottomLeft;
                dxfDocument.AddEntity(text);

                // save to file
                dxfDocument.Save(file);
            }
        }
    }
}
