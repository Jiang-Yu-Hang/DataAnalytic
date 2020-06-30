/*
               File: type_SdtBR_Familyhistory
        Description: ¼Ò×åÊ·
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:5.39
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
   [XmlRoot(ElementName = "BR_Familyhistory" )]
   [XmlType(TypeName =  "BR_Familyhistory" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Familyhistory : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Familyhistory( )
      {
      }

      public SdtBR_Familyhistory( IGxContext context )
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

      public void Load( long AV576BR_FamilyhistoryID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV576BR_FamilyhistoryID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_FamilyhistoryID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Familyhistory");
         metadata.Set("BT", "BR_Familyhistory");
         metadata.Set("PK", "[ \"BR_FamilyhistoryID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_FamilyhistoryID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_EncounterID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_familyhistoryid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_familycahistory_Z");
         state.Add("gxTpr_Br_familycahistory_code_Z");
         state.Add("gxTpr_Br_familycancer_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_familycahistory_N");
         state.Add("gxTpr_Br_familycahistory_code_N");
         state.Add("gxTpr_Br_familycancer_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Familyhistory sdt ;
         sdt = (SdtBR_Familyhistory)(source);
         gxTv_SdtBR_Familyhistory_Br_familyhistoryid = sdt.gxTv_SdtBR_Familyhistory_Br_familyhistoryid ;
         gxTv_SdtBR_Familyhistory_Br_encounterid = sdt.gxTv_SdtBR_Familyhistory_Br_encounterid ;
         gxTv_SdtBR_Familyhistory_Br_information_patientno = sdt.gxTv_SdtBR_Familyhistory_Br_information_patientno ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_code ;
         gxTv_SdtBR_Familyhistory_Br_familycancer = sdt.gxTv_SdtBR_Familyhistory_Br_familycancer ;
         gxTv_SdtBR_Familyhistory_Mode = sdt.gxTv_SdtBR_Familyhistory_Mode ;
         gxTv_SdtBR_Familyhistory_Initialized = sdt.gxTv_SdtBR_Familyhistory_Initialized ;
         gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z = sdt.gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z ;
         gxTv_SdtBR_Familyhistory_Br_encounterid_Z = sdt.gxTv_SdtBR_Familyhistory_Br_encounterid_Z ;
         gxTv_SdtBR_Familyhistory_Br_information_patientno_Z = sdt.gxTv_SdtBR_Familyhistory_Br_information_patientno_Z ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_Z = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_Z ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z ;
         gxTv_SdtBR_Familyhistory_Br_familycancer_Z = sdt.gxTv_SdtBR_Familyhistory_Br_familycancer_Z ;
         gxTv_SdtBR_Familyhistory_Br_information_patientno_N = sdt.gxTv_SdtBR_Familyhistory_Br_information_patientno_N ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_N = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_N ;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N ;
         gxTv_SdtBR_Familyhistory_Br_familycancer_N = sdt.gxTv_SdtBR_Familyhistory_Br_familycancer_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Familyhistory_Br_familyhistoryid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Familyhistory_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Familyhistory_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Familyhistory_Br_information_patientno_N, false);
         AddObjectProperty("BR_FamilyCaHistory", gxTv_SdtBR_Familyhistory_Br_familycahistory, false);
         AddObjectProperty("BR_FamilyCaHistory_N", gxTv_SdtBR_Familyhistory_Br_familycahistory_N, false);
         AddObjectProperty("BR_FamilyCaHistory_Code", gxTv_SdtBR_Familyhistory_Br_familycahistory_code, false);
         AddObjectProperty("BR_FamilyCaHistory_Code_N", gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N, false);
         AddObjectProperty("BR_FamilyCancer", gxTv_SdtBR_Familyhistory_Br_familycancer, false);
         AddObjectProperty("BR_FamilyCancer_N", gxTv_SdtBR_Familyhistory_Br_familycancer_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Familyhistory_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Familyhistory_Initialized, false);
            AddObjectProperty("BR_FamilyhistoryID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Familyhistory_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Familyhistory_Br_information_patientno_Z, false);
            AddObjectProperty("BR_FamilyCaHistory_Z", gxTv_SdtBR_Familyhistory_Br_familycahistory_Z, false);
            AddObjectProperty("BR_FamilyCaHistory_Code_Z", gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z, false);
            AddObjectProperty("BR_FamilyCancer_Z", gxTv_SdtBR_Familyhistory_Br_familycancer_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Familyhistory_Br_information_patientno_N, false);
            AddObjectProperty("BR_FamilyCaHistory_N", gxTv_SdtBR_Familyhistory_Br_familycahistory_N, false);
            AddObjectProperty("BR_FamilyCaHistory_Code_N", gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N, false);
            AddObjectProperty("BR_FamilyCancer_N", gxTv_SdtBR_Familyhistory_Br_familycancer_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Familyhistory sdt )
      {
         if ( sdt.IsDirty("BR_FamilyhistoryID") )
         {
            gxTv_SdtBR_Familyhistory_Br_familyhistoryid = sdt.gxTv_SdtBR_Familyhistory_Br_familyhistoryid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Familyhistory_Br_encounterid = sdt.gxTv_SdtBR_Familyhistory_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Familyhistory_Br_information_patientno = sdt.gxTv_SdtBR_Familyhistory_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_FamilyCaHistory") )
         {
            gxTv_SdtBR_Familyhistory_Br_familycahistory = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory ;
         }
         if ( sdt.IsDirty("BR_FamilyCaHistory_Code") )
         {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_code = sdt.gxTv_SdtBR_Familyhistory_Br_familycahistory_code ;
         }
         if ( sdt.IsDirty("BR_FamilyCancer") )
         {
            gxTv_SdtBR_Familyhistory_Br_familycancer = sdt.gxTv_SdtBR_Familyhistory_Br_familycancer ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_FamilyhistoryID" )]
      [  XmlElement( ElementName = "BR_FamilyhistoryID"   )]
      public long gxTpr_Br_familyhistoryid
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familyhistoryid ;
         }

         set {
            if ( gxTv_SdtBR_Familyhistory_Br_familyhistoryid != value )
            {
               gxTv_SdtBR_Familyhistory_Mode = "INS";
               this.gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z_SetNull( );
               this.gxTv_SdtBR_Familyhistory_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Familyhistory_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Familyhistory_Br_familycahistory_Z_SetNull( );
               this.gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z_SetNull( );
               this.gxTv_SdtBR_Familyhistory_Br_familycancer_Z_SetNull( );
            }
            gxTv_SdtBR_Familyhistory_Br_familyhistoryid = value;
            SetDirty("Br_familyhistoryid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_information_patientno_N = 0;
            gxTv_SdtBR_Familyhistory_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_information_patientno_N = 1;
         gxTv_SdtBR_Familyhistory_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory"   )]
      public String gxTpr_Br_familycahistory
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_N = 0;
            gxTv_SdtBR_Familyhistory_Br_familycahistory = value;
            SetDirty("Br_familycahistory");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_N = 1;
         gxTv_SdtBR_Familyhistory_Br_familycahistory = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory_Code" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory_Code"   )]
      public String gxTpr_Br_familycahistory_code
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory_code ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N = 0;
            gxTv_SdtBR_Familyhistory_Br_familycahistory_code = value;
            SetDirty("Br_familycahistory_code");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_code_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N = 1;
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCancer" )]
      [  XmlElement( ElementName = "BR_FamilyCancer"   )]
      public String gxTpr_Br_familycancer
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycancer ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycancer_N = 0;
            gxTv_SdtBR_Familyhistory_Br_familycancer = value;
            SetDirty("Br_familycancer");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycancer_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycancer_N = 1;
         gxTv_SdtBR_Familyhistory_Br_familycancer = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycancer_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Familyhistory_Mode ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Mode_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Familyhistory_Initialized ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Initialized_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyhistoryID_Z" )]
      [  XmlElement( ElementName = "BR_FamilyhistoryID_Z"   )]
      public long gxTpr_Br_familyhistoryid_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z = value;
            SetDirty("Br_familyhistoryid_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory_Z" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory_Z"   )]
      public String gxTpr_Br_familycahistory_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_Z = value;
            SetDirty("Br_familycahistory_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory_Code_Z" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory_Code_Z"   )]
      public String gxTpr_Br_familycahistory_code_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z = value;
            SetDirty("Br_familycahistory_code_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCancer_Z" )]
      [  XmlElement( ElementName = "BR_FamilyCancer_Z"   )]
      public String gxTpr_Br_familycancer_Z
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycancer_Z ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycancer_Z = value;
            SetDirty("Br_familycancer_Z");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycancer_Z_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycancer_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycancer_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory_N" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory_N"   )]
      public short gxTpr_Br_familycahistory_N
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory_N ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_N = value;
            SetDirty("Br_familycahistory_N");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_N_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCaHistory_Code_N" )]
      [  XmlElement( ElementName = "BR_FamilyCaHistory_Code_N"   )]
      public short gxTpr_Br_familycahistory_code_N
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N = value;
            SetDirty("Br_familycahistory_code_N");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_FamilyCancer_N" )]
      [  XmlElement( ElementName = "BR_FamilyCancer_N"   )]
      public short gxTpr_Br_familycancer_N
      {
         get {
            return gxTv_SdtBR_Familyhistory_Br_familycancer_N ;
         }

         set {
            gxTv_SdtBR_Familyhistory_Br_familycancer_N = value;
            SetDirty("Br_familycancer_N");
         }

      }

      public void gxTv_SdtBR_Familyhistory_Br_familycancer_N_SetNull( )
      {
         gxTv_SdtBR_Familyhistory_Br_familycancer_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Familyhistory_Br_familycancer_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Familyhistory_Br_information_patientno = "";
         gxTv_SdtBR_Familyhistory_Br_familycahistory = "";
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code = "";
         gxTv_SdtBR_Familyhistory_Br_familycancer = "";
         gxTv_SdtBR_Familyhistory_Mode = "";
         gxTv_SdtBR_Familyhistory_Br_information_patientno_Z = "";
         gxTv_SdtBR_Familyhistory_Br_familycahistory_Z = "";
         gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z = "";
         gxTv_SdtBR_Familyhistory_Br_familycancer_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_familyhistory", "GeneXus.Programs.br_familyhistory_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Familyhistory_Initialized ;
      private short gxTv_SdtBR_Familyhistory_Br_information_patientno_N ;
      private short gxTv_SdtBR_Familyhistory_Br_familycahistory_N ;
      private short gxTv_SdtBR_Familyhistory_Br_familycahistory_code_N ;
      private short gxTv_SdtBR_Familyhistory_Br_familycancer_N ;
      private long gxTv_SdtBR_Familyhistory_Br_familyhistoryid ;
      private long gxTv_SdtBR_Familyhistory_Br_encounterid ;
      private long gxTv_SdtBR_Familyhistory_Br_familyhistoryid_Z ;
      private long gxTv_SdtBR_Familyhistory_Br_encounterid_Z ;
      private String gxTv_SdtBR_Familyhistory_Mode ;
      private String gxTv_SdtBR_Familyhistory_Br_information_patientno ;
      private String gxTv_SdtBR_Familyhistory_Br_familycahistory ;
      private String gxTv_SdtBR_Familyhistory_Br_familycahistory_code ;
      private String gxTv_SdtBR_Familyhistory_Br_familycancer ;
      private String gxTv_SdtBR_Familyhistory_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Familyhistory_Br_familycahistory_Z ;
      private String gxTv_SdtBR_Familyhistory_Br_familycahistory_code_Z ;
      private String gxTv_SdtBR_Familyhistory_Br_familycancer_Z ;
   }

   [DataContract(Name = @"BR_Familyhistory", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Familyhistory_RESTInterface : GxGenericCollectionItem<SdtBR_Familyhistory>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Familyhistory_RESTInterface( ) : base()
      {
      }

      public SdtBR_Familyhistory_RESTInterface( SdtBR_Familyhistory psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_FamilyhistoryID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_familyhistoryid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_familyhistoryid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_familyhistoryid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_EncounterID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_information_patientno
      {
         get {
            return sdt.gxTpr_Br_information_patientno ;
         }

         set {
            sdt.gxTpr_Br_information_patientno = value;
         }

      }

      [DataMember( Name = "BR_FamilyCaHistory" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_familycahistory
      {
         get {
            return sdt.gxTpr_Br_familycahistory ;
         }

         set {
            sdt.gxTpr_Br_familycahistory = value;
         }

      }

      [DataMember( Name = "BR_FamilyCaHistory_Code" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_familycahistory_code
      {
         get {
            return sdt.gxTpr_Br_familycahistory_code ;
         }

         set {
            sdt.gxTpr_Br_familycahistory_code = value;
         }

      }

      [DataMember( Name = "BR_FamilyCancer" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_familycancer
      {
         get {
            return sdt.gxTpr_Br_familycancer ;
         }

         set {
            sdt.gxTpr_Br_familycancer = value;
         }

      }

      public SdtBR_Familyhistory sdt
      {
         get {
            return (SdtBR_Familyhistory)Sdt ;
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
            sdt = new SdtBR_Familyhistory() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
