/*
               File: wwpbaseobjects.type_SdtSecFunctionality
        Description: х╗оч
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:23.72
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
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SecFunctionality" )]
   [XmlType(TypeName =  "SecFunctionality" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecFunctionality : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecFunctionality( )
      {
      }

      public SdtSecFunctionality( IGxContext context )
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

      public void Load( long AV1SecFunctionalityId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV1SecFunctionalityId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecFunctionalityId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecFunctionality");
         metadata.Set("BT", "SecFunctionality");
         metadata.Set("PK", "[ \"SecFunctionalityId\" ]");
         metadata.Set("PKAssigned", "[ \"SecFunctionalityId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SecFunctionalityId\" ],\"FKMap\":[ \"SecParentFunctionalityId-SecFunctionalityId\" ] } ]");
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
         state.Add("gxTpr_Secfunctionalityid_Z");
         state.Add("gxTpr_Secfunctionalitykey_Z");
         state.Add("gxTpr_Secfunctionalitydescription_Z");
         state.Add("gxTpr_Secfunctionalitytype_Z");
         state.Add("gxTpr_Secparentfunctionalityid_Z");
         state.Add("gxTpr_Secparentfunctionalitydescription_Z");
         state.Add("gxTpr_Secfunctionalityactive_Z");
         state.Add("gxTpr_Secparentfunctionalityid_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality)(source);
         gxTv_SdtSecFunctionality_Secfunctionalityid = sdt.gxTv_SdtSecFunctionality_Secfunctionalityid ;
         gxTv_SdtSecFunctionality_Secfunctionalitykey = sdt.gxTv_SdtSecFunctionality_Secfunctionalitykey ;
         gxTv_SdtSecFunctionality_Secfunctionalitydescription = sdt.gxTv_SdtSecFunctionality_Secfunctionalitydescription ;
         gxTv_SdtSecFunctionality_Secfunctionalitytype = sdt.gxTv_SdtSecFunctionality_Secfunctionalitytype ;
         gxTv_SdtSecFunctionality_Secparentfunctionalityid = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalityid ;
         gxTv_SdtSecFunctionality_Secparentfunctionalitydescription = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalitydescription ;
         gxTv_SdtSecFunctionality_Secfunctionalityactive = sdt.gxTv_SdtSecFunctionality_Secfunctionalityactive ;
         gxTv_SdtSecFunctionality_Mode = sdt.gxTv_SdtSecFunctionality_Mode ;
         gxTv_SdtSecFunctionality_Initialized = sdt.gxTv_SdtSecFunctionality_Initialized ;
         gxTv_SdtSecFunctionality_Secfunctionalityid_Z = sdt.gxTv_SdtSecFunctionality_Secfunctionalityid_Z ;
         gxTv_SdtSecFunctionality_Secfunctionalitykey_Z = sdt.gxTv_SdtSecFunctionality_Secfunctionalitykey_Z ;
         gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z = sdt.gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z ;
         gxTv_SdtSecFunctionality_Secfunctionalitytype_Z = sdt.gxTv_SdtSecFunctionality_Secfunctionalitytype_Z ;
         gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z ;
         gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z ;
         gxTv_SdtSecFunctionality_Secfunctionalityactive_Z = sdt.gxTv_SdtSecFunctionality_Secfunctionalityactive_Z ;
         gxTv_SdtSecFunctionality_Secparentfunctionalityid_N = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalityid_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecFunctionalityId", gxTv_SdtSecFunctionality_Secfunctionalityid, false);
         AddObjectProperty("SecFunctionalityKey", gxTv_SdtSecFunctionality_Secfunctionalitykey, false);
         AddObjectProperty("SecFunctionalityDescription", gxTv_SdtSecFunctionality_Secfunctionalitydescription, false);
         AddObjectProperty("SecFunctionalityType", gxTv_SdtSecFunctionality_Secfunctionalitytype, false);
         AddObjectProperty("SecParentFunctionalityId", gxTv_SdtSecFunctionality_Secparentfunctionalityid, false);
         AddObjectProperty("SecParentFunctionalityId_N", gxTv_SdtSecFunctionality_Secparentfunctionalityid_N, false);
         AddObjectProperty("SecParentFunctionalityDescription", gxTv_SdtSecFunctionality_Secparentfunctionalitydescription, false);
         AddObjectProperty("SecFunctionalityActive", gxTv_SdtSecFunctionality_Secfunctionalityactive, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecFunctionality_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecFunctionality_Initialized, false);
            AddObjectProperty("SecFunctionalityId_Z", gxTv_SdtSecFunctionality_Secfunctionalityid_Z, false);
            AddObjectProperty("SecFunctionalityKey_Z", gxTv_SdtSecFunctionality_Secfunctionalitykey_Z, false);
            AddObjectProperty("SecFunctionalityDescription_Z", gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z, false);
            AddObjectProperty("SecFunctionalityType_Z", gxTv_SdtSecFunctionality_Secfunctionalitytype_Z, false);
            AddObjectProperty("SecParentFunctionalityId_Z", gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z, false);
            AddObjectProperty("SecParentFunctionalityDescription_Z", gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z, false);
            AddObjectProperty("SecFunctionalityActive_Z", gxTv_SdtSecFunctionality_Secfunctionalityactive_Z, false);
            AddObjectProperty("SecParentFunctionalityId_N", gxTv_SdtSecFunctionality_Secparentfunctionalityid_N, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality sdt )
      {
         if ( sdt.IsDirty("SecFunctionalityId") )
         {
            gxTv_SdtSecFunctionality_Secfunctionalityid = sdt.gxTv_SdtSecFunctionality_Secfunctionalityid ;
         }
         if ( sdt.IsDirty("SecFunctionalityKey") )
         {
            gxTv_SdtSecFunctionality_Secfunctionalitykey = sdt.gxTv_SdtSecFunctionality_Secfunctionalitykey ;
         }
         if ( sdt.IsDirty("SecFunctionalityDescription") )
         {
            gxTv_SdtSecFunctionality_Secfunctionalitydescription = sdt.gxTv_SdtSecFunctionality_Secfunctionalitydescription ;
         }
         if ( sdt.IsDirty("SecFunctionalityType") )
         {
            gxTv_SdtSecFunctionality_Secfunctionalitytype = sdt.gxTv_SdtSecFunctionality_Secfunctionalitytype ;
         }
         if ( sdt.IsDirty("SecParentFunctionalityId") )
         {
            gxTv_SdtSecFunctionality_Secparentfunctionalityid = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalityid ;
         }
         if ( sdt.IsDirty("SecParentFunctionalityDescription") )
         {
            gxTv_SdtSecFunctionality_Secparentfunctionalitydescription = sdt.gxTv_SdtSecFunctionality_Secparentfunctionalitydescription ;
         }
         if ( sdt.IsDirty("SecFunctionalityActive") )
         {
            gxTv_SdtSecFunctionality_Secfunctionalityactive = sdt.gxTv_SdtSecFunctionality_Secfunctionalityactive ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId" )]
      [  XmlElement( ElementName = "SecFunctionalityId"   )]
      public long gxTpr_Secfunctionalityid
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalityid ;
         }

         set {
            if ( gxTv_SdtSecFunctionality_Secfunctionalityid != value )
            {
               gxTv_SdtSecFunctionality_Mode = "INS";
               this.gxTv_SdtSecFunctionality_Secfunctionalityid_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secfunctionalitykey_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secfunctionalitytype_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z_SetNull( );
               this.gxTv_SdtSecFunctionality_Secfunctionalityactive_Z_SetNull( );
            }
            gxTv_SdtSecFunctionality_Secfunctionalityid = value;
            SetDirty("Secfunctionalityid");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityKey" )]
      [  XmlElement( ElementName = "SecFunctionalityKey"   )]
      public String gxTpr_Secfunctionalitykey
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitykey ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitykey = value;
            SetDirty("Secfunctionalitykey");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityDescription" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription"   )]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitydescription ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitydescription = value;
            SetDirty("Secfunctionalitydescription");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityType" )]
      [  XmlElement( ElementName = "SecFunctionalityType"   )]
      public short gxTpr_Secfunctionalitytype
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitytype ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitytype = value;
            SetDirty("Secfunctionalitytype");
         }

      }

      [  SoapElement( ElementName = "SecParentFunctionalityId" )]
      [  XmlElement( ElementName = "SecParentFunctionalityId"   )]
      public long gxTpr_Secparentfunctionalityid
      {
         get {
            return gxTv_SdtSecFunctionality_Secparentfunctionalityid ;
         }

         set {
            gxTv_SdtSecFunctionality_Secparentfunctionalityid_N = 0;
            gxTv_SdtSecFunctionality_Secparentfunctionalityid = value;
            SetDirty("Secparentfunctionalityid");
         }

      }

      public void gxTv_SdtSecFunctionality_Secparentfunctionalityid_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secparentfunctionalityid_N = 1;
         gxTv_SdtSecFunctionality_Secparentfunctionalityid = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secparentfunctionalityid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecParentFunctionalityDescription" )]
      [  XmlElement( ElementName = "SecParentFunctionalityDescription"   )]
      public String gxTpr_Secparentfunctionalitydescription
      {
         get {
            return gxTv_SdtSecFunctionality_Secparentfunctionalitydescription ;
         }

         set {
            gxTv_SdtSecFunctionality_Secparentfunctionalitydescription = value;
            SetDirty("Secparentfunctionalitydescription");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityActive" )]
      [  XmlElement( ElementName = "SecFunctionalityActive"   )]
      public bool gxTpr_Secfunctionalityactive
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalityactive ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalityactive = value;
            SetDirty("Secfunctionalityactive");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecFunctionality_Mode ;
         }

         set {
            gxTv_SdtSecFunctionality_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecFunctionality_Mode_SetNull( )
      {
         gxTv_SdtSecFunctionality_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecFunctionality_Initialized ;
         }

         set {
            gxTv_SdtSecFunctionality_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecFunctionality_Initialized_SetNull( )
      {
         gxTv_SdtSecFunctionality_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityId_Z"   )]
      public long gxTpr_Secfunctionalityid_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalityid_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalityid_Z = value;
            SetDirty("Secfunctionalityid_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secfunctionalityid_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalityid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secfunctionalityid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityKey_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityKey_Z"   )]
      public String gxTpr_Secfunctionalitykey_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitykey_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitykey_Z = value;
            SetDirty("Secfunctionalitykey_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secfunctionalitykey_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalitykey_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secfunctionalitykey_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityDescription_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription_Z"   )]
      public String gxTpr_Secfunctionalitydescription_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z = value;
            SetDirty("Secfunctionalitydescription_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityType_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityType_Z"   )]
      public short gxTpr_Secfunctionalitytype_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalitytype_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalitytype_Z = value;
            SetDirty("Secfunctionalitytype_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secfunctionalitytype_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalitytype_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secfunctionalitytype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecParentFunctionalityId_Z" )]
      [  XmlElement( ElementName = "SecParentFunctionalityId_Z"   )]
      public long gxTpr_Secparentfunctionalityid_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z = value;
            SetDirty("Secparentfunctionalityid_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecParentFunctionalityDescription_Z" )]
      [  XmlElement( ElementName = "SecParentFunctionalityDescription_Z"   )]
      public String gxTpr_Secparentfunctionalitydescription_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z = value;
            SetDirty("Secparentfunctionalitydescription_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityActive_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityActive_Z"   )]
      public bool gxTpr_Secfunctionalityactive_Z
      {
         get {
            return gxTv_SdtSecFunctionality_Secfunctionalityactive_Z ;
         }

         set {
            gxTv_SdtSecFunctionality_Secfunctionalityactive_Z = value;
            SetDirty("Secfunctionalityactive_Z");
         }

      }

      public void gxTv_SdtSecFunctionality_Secfunctionalityactive_Z_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalityactive_Z = false;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secfunctionalityactive_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecParentFunctionalityId_N" )]
      [  XmlElement( ElementName = "SecParentFunctionalityId_N"   )]
      public short gxTpr_Secparentfunctionalityid_N
      {
         get {
            return gxTv_SdtSecFunctionality_Secparentfunctionalityid_N ;
         }

         set {
            gxTv_SdtSecFunctionality_Secparentfunctionalityid_N = value;
            SetDirty("Secparentfunctionalityid_N");
         }

      }

      public void gxTv_SdtSecFunctionality_Secparentfunctionalityid_N_SetNull( )
      {
         gxTv_SdtSecFunctionality_Secparentfunctionalityid_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionality_Secparentfunctionalityid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecFunctionality_Secfunctionalitykey = "";
         gxTv_SdtSecFunctionality_Secfunctionalitydescription = "";
         gxTv_SdtSecFunctionality_Secparentfunctionalitydescription = "";
         gxTv_SdtSecFunctionality_Mode = "";
         gxTv_SdtSecFunctionality_Secfunctionalitykey_Z = "";
         gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z = "";
         gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secfunctionality", "GeneXus.Programs.wwpbaseobjects.secfunctionality_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecFunctionality_Secfunctionalitytype ;
      private short gxTv_SdtSecFunctionality_Initialized ;
      private short gxTv_SdtSecFunctionality_Secfunctionalitytype_Z ;
      private short gxTv_SdtSecFunctionality_Secparentfunctionalityid_N ;
      private long gxTv_SdtSecFunctionality_Secfunctionalityid ;
      private long gxTv_SdtSecFunctionality_Secparentfunctionalityid ;
      private long gxTv_SdtSecFunctionality_Secfunctionalityid_Z ;
      private long gxTv_SdtSecFunctionality_Secparentfunctionalityid_Z ;
      private String gxTv_SdtSecFunctionality_Mode ;
      private bool gxTv_SdtSecFunctionality_Secfunctionalityactive ;
      private bool gxTv_SdtSecFunctionality_Secfunctionalityactive_Z ;
      private String gxTv_SdtSecFunctionality_Secfunctionalitykey ;
      private String gxTv_SdtSecFunctionality_Secfunctionalitydescription ;
      private String gxTv_SdtSecFunctionality_Secparentfunctionalitydescription ;
      private String gxTv_SdtSecFunctionality_Secfunctionalitykey_Z ;
      private String gxTv_SdtSecFunctionality_Secfunctionalitydescription_Z ;
      private String gxTv_SdtSecFunctionality_Secparentfunctionalitydescription_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecFunctionality", Namespace = "DataAnalysisPlatform")]
   public class SdtSecFunctionality_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecFunctionality_RESTInterface( ) : base()
      {
      }

      public SdtSecFunctionality_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecFunctionalityId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalityid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Secfunctionalityid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Secfunctionalityid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SecFunctionalityKey" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalitykey
      {
         get {
            return sdt.gxTpr_Secfunctionalitykey ;
         }

         set {
            sdt.gxTpr_Secfunctionalitykey = value;
         }

      }

      [DataMember( Name = "SecFunctionalityDescription" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return sdt.gxTpr_Secfunctionalitydescription ;
         }

         set {
            sdt.gxTpr_Secfunctionalitydescription = value;
         }

      }

      [DataMember( Name = "SecFunctionalityType" , Order = 3 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secfunctionalitytype
      {
         get {
            return sdt.gxTpr_Secfunctionalitytype ;
         }

         set {
            sdt.gxTpr_Secfunctionalitytype = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SecParentFunctionalityId" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Secparentfunctionalityid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Secparentfunctionalityid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Secparentfunctionalityid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SecParentFunctionalityDescription" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Secparentfunctionalitydescription
      {
         get {
            return sdt.gxTpr_Secparentfunctionalitydescription ;
         }

         set {
            sdt.gxTpr_Secparentfunctionalitydescription = value;
         }

      }

      [DataMember( Name = "SecFunctionalityActive" , Order = 6 )]
      [GxSeudo()]
      public bool gxTpr_Secfunctionalityactive
      {
         get {
            return sdt.gxTpr_Secfunctionalityactive ;
         }

         set {
            sdt.gxTpr_Secfunctionalityactive = value;
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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
