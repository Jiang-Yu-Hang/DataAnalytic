/*
               File: type_SdtBR_Medication_Detail
        Description: 药物治疗药物详情0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:43.69
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "BR_Medication_Detail" )]
   [XmlType(TypeName =  "BR_Medication_Detail" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Medication_Detail : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication_Detail( )
      {
      }

      public SdtBR_Medication_Detail( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( long AV301BR_Medication_DetailID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV301BR_Medication_DetailID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Medication_DetailID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Medication_Detail");
         metadata.Set("BT", "BR_Medication_Detail");
         metadata.Set("PK", "[ \"BR_Medication_DetailID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Medication_DetailID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_Medication_SchemeID\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Br_medication_detailid_Z");
         state.Add("gxTpr_Br_medication_schemeid_Z");
         state.Add("gxTpr_Br_medication_drug_name_Z");
         state.Add("gxTpr_Br_medication_drug_num_Z_double");
         state.Add("gxTpr_Br_medication_drug_unit_Z");
         state.Add("gxTpr_Br_medication_schemeid_N");
         state.Add("gxTpr_Br_medication_drug_name_N");
         state.Add("gxTpr_Br_medication_drug_num_N");
         state.Add("gxTpr_Br_medication_drug_unit_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Medication_Detail sdt ;
         sdt = (SdtBR_Medication_Detail)(source);
         gxTv_SdtBR_Medication_Detail_Br_medication_detailid = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_detailid ;
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_schemeid ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_name ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_num ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit ;
         gxTv_SdtBR_Medication_Detail_Mode = sdt.gxTv_SdtBR_Medication_Detail_Mode ;
         gxTv_SdtBR_Medication_Detail_Initialized = sdt.gxTv_SdtBR_Medication_Detail_Initialized ;
         gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z ;
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z ;
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N ;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Detail_Br_medication_detailid), 18, 0)), false);
         AddObjectProperty("BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Detail_Br_medication_schemeid), 18, 0)), false);
         AddObjectProperty("BR_Medication_SchemeID_N", gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N, false);
         AddObjectProperty("BR_Medication_Drug_Name", gxTv_SdtBR_Medication_Detail_Br_medication_drug_name, false);
         AddObjectProperty("BR_Medication_Drug_Name_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N, false);
         AddObjectProperty("BR_Medication_Drug_Num", gxTv_SdtBR_Medication_Detail_Br_medication_drug_num, false);
         AddObjectProperty("BR_Medication_Drug_Num_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N, false);
         AddObjectProperty("BR_Medication_Drug_Unit", gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit, false);
         AddObjectProperty("BR_Medication_Drug_Unit_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Medication_Detail_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Medication_Detail_Initialized, false);
            AddObjectProperty("BR_Medication_DetailID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z), 18, 0)), false);
            AddObjectProperty("BR_Medication_SchemeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z), 18, 0)), false);
            AddObjectProperty("BR_Medication_Drug_Name_Z", gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z, false);
            AddObjectProperty("BR_Medication_Drug_Num_Z", gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z, false);
            AddObjectProperty("BR_Medication_Drug_Unit_Z", gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z, false);
            AddObjectProperty("BR_Medication_SchemeID_N", gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N, false);
            AddObjectProperty("BR_Medication_Drug_Name_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N, false);
            AddObjectProperty("BR_Medication_Drug_Num_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N, false);
            AddObjectProperty("BR_Medication_Drug_Unit_N", gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Medication_Detail sdt )
      {
         if ( sdt.IsDirty("BR_Medication_DetailID") )
         {
            gxTv_SdtBR_Medication_Detail_Br_medication_detailid = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_detailid ;
         }
         if ( sdt.IsDirty("BR_Medication_SchemeID") )
         {
            gxTv_SdtBR_Medication_Detail_Br_medication_schemeid = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_schemeid ;
         }
         if ( sdt.IsDirty("BR_Medication_Drug_Name") )
         {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_name = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_name ;
         }
         if ( sdt.IsDirty("BR_Medication_Drug_Num") )
         {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_num ;
         }
         if ( sdt.IsDirty("BR_Medication_Drug_Unit") )
         {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit = sdt.gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Medication_DetailID" )]
      [  XmlElement( ElementName = "BR_Medication_DetailID"   )]
      public long gxTpr_Br_medication_detailid
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_detailid ;
         }

         set {
            if ( gxTv_SdtBR_Medication_Detail_Br_medication_detailid != value )
            {
               gxTv_SdtBR_Medication_Detail_Mode = "INS";
               this.gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z_SetNull( );
            }
            gxTv_SdtBR_Medication_Detail_Br_medication_detailid = value;
            SetDirty("Br_medication_detailid");
         }

      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID"   )]
      public long gxTpr_Br_medication_schemeid
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_schemeid ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N = 0;
            gxTv_SdtBR_Medication_Detail_Br_medication_schemeid = value;
            SetDirty("Br_medication_schemeid");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N = 1;
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Name" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Name"   )]
      public String gxTpr_Br_medication_drug_name
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_name ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N = 0;
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_name = value;
            SetDirty("Br_medication_drug_name");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N = 1;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Num" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Num"   )]
      public double gxTpr_Br_medication_drug_num_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Detail_Br_medication_drug_num) ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = 0;
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_drug_num
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_num ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = 0;
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num = value;
            SetDirty("Br_medication_drug_num");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = 1;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Unit" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Unit"   )]
      public String gxTpr_Br_medication_drug_unit
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N = 0;
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit = value;
            SetDirty("Br_medication_drug_unit");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N = 1;
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Mode ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Mode_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Initialized ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Initialized_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_DetailID_Z" )]
      [  XmlElement( ElementName = "BR_Medication_DetailID_Z"   )]
      public long gxTpr_Br_medication_detailid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z = value;
            SetDirty("Br_medication_detailid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID_Z" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID_Z"   )]
      public long gxTpr_Br_medication_schemeid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z = value;
            SetDirty("Br_medication_schemeid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Name_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Name_Z"   )]
      public String gxTpr_Br_medication_drug_name_Z
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z = value;
            SetDirty("Br_medication_drug_name_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Num_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Num_Z"   )]
      public double gxTpr_Br_medication_drug_num_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z) ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_drug_num_Z
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z = value;
            SetDirty("Br_medication_drug_num_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Unit_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Unit_Z"   )]
      public String gxTpr_Br_medication_drug_unit_Z
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z = value;
            SetDirty("Br_medication_drug_unit_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID_N" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID_N"   )]
      public short gxTpr_Br_medication_schemeid_N
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N = value;
            SetDirty("Br_medication_schemeid_N");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Name_N" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Name_N"   )]
      public short gxTpr_Br_medication_drug_name_N
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N = value;
            SetDirty("Br_medication_drug_name_N");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Num_N" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Num_N"   )]
      public short gxTpr_Br_medication_drug_num_N
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = value;
            SetDirty("Br_medication_drug_num_N");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Drug_Unit_N" )]
      [  XmlElement( ElementName = "BR_Medication_Drug_Unit_N"   )]
      public short gxTpr_Br_medication_drug_unit_N
      {
         get {
            return gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N ;
         }

         set {
            gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N = value;
            SetDirty("Br_medication_drug_unit_N");
         }

      }

      public void gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name = "";
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit = "";
         gxTv_SdtBR_Medication_Detail_Mode = "";
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z = "";
         gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_medication_detail", "GeneXus.Programs.br_medication_detail_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Medication_Detail_Initialized ;
      private short gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_N ;
      private short gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_N ;
      private short gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_N ;
      private short gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_N ;
      private long gxTv_SdtBR_Medication_Detail_Br_medication_detailid ;
      private long gxTv_SdtBR_Medication_Detail_Br_medication_schemeid ;
      private long gxTv_SdtBR_Medication_Detail_Br_medication_detailid_Z ;
      private long gxTv_SdtBR_Medication_Detail_Br_medication_schemeid_Z ;
      private decimal gxTv_SdtBR_Medication_Detail_Br_medication_drug_num ;
      private decimal gxTv_SdtBR_Medication_Detail_Br_medication_drug_num_Z ;
      private String gxTv_SdtBR_Medication_Detail_Mode ;
      private String gxTv_SdtBR_Medication_Detail_Br_medication_drug_name ;
      private String gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit ;
      private String gxTv_SdtBR_Medication_Detail_Br_medication_drug_name_Z ;
      private String gxTv_SdtBR_Medication_Detail_Br_medication_drug_unit_Z ;
   }

   [DataContract(Name = @"BR_Medication_Detail", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Medication_Detail_RESTInterface : GxGenericCollectionItem<SdtBR_Medication_Detail>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication_Detail_RESTInterface( ) : base()
      {
      }

      public SdtBR_Medication_Detail_RESTInterface( SdtBR_Medication_Detail psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Medication_DetailID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_detailid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medication_detailid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medication_detailid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Medication_SchemeID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_schemeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medication_schemeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medication_schemeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Medication_Drug_Name" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_drug_name
      {
         get {
            return sdt.gxTpr_Br_medication_drug_name ;
         }

         set {
            sdt.gxTpr_Br_medication_drug_name = value;
         }

      }

      [DataMember( Name = "BR_Medication_Drug_Num" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_drug_num
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_medication_drug_num, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_medication_drug_num = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Medication_Drug_Unit" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_drug_unit
      {
         get {
            return sdt.gxTpr_Br_medication_drug_unit ;
         }

         set {
            sdt.gxTpr_Br_medication_drug_unit = value;
         }

      }

      public SdtBR_Medication_Detail sdt
      {
         get {
            return (SdtBR_Medication_Detail)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtBR_Medication_Detail() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 5 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
