﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Cafe.Module.Cafe
{

    public partial class Sanpham
    {
        public Sanpham(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
