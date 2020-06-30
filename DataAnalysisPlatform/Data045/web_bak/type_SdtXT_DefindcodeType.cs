/*
               File: type_SdtXT_DefindcodeType
        Description: 数据字典类型
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:11.72
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
   [XmlRoot(ElementName = "XT_DefindcodeType" )]
   [XmlType(TypeName =  "XT_DefindcodeType" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtXT_DefindcodeType : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_DefindcodeType( )
      {
      }

      public SdtXT_DefindcodeType( IGxContext context )
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

      public void Load( long AV165XT_DefindcodeTypeID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV165XT_DefindcodeTypeID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"XT_DefindcodeTypeID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "XT_DefindcodeType");
         metadata.Set("BT", "XT_DefindcodeType");
         metadata.Set("PK", "[ \"XT_DefindcodeTypeID\" ]");
         metadata.Set("PKAssigned", "[ \"XT_DefindcodeTypeID\" ]");
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
         state.Add("gxTpr_Xt_defindcodetypeid_Z");
         state.Add("gxTpr_Xt_defindcodetypename_Z");
         state.Add("gxTpr_Xt_defindcodetypeisshow_Z");
         state.Add("gxTpr_Xt_defindcodetypename_N");
         state.Add("gxTpr_Xt_defindcodetypeisshow_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtXT_DefindcodeType sdt ;
         sdt = (SdtXT_DefindcodeType)(source);
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow ;
         gxTv_SdtXT_DefindcodeType_Mode = sdt.gxTv_SdtXT_DefindcodeType_Mode ;
         gxTv_SdtXT_DefindcodeType_Initialized = sdt.gxTv_SdtXT_DefindcodeType_Initialized ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N ;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid), 18, 0)), false);
         AddObjectProperty("XT_DefindcodeTypeName", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename, false);
         AddObjectProperty("XT_DefindcodeTypeName_N", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N, false);
         AddObjectProperty("XT_DefindcodeTypeIsShow", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow, false);
         AddObjectProperty("XT_DefindcodeTypeIsShow_N", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtXT_DefindcodeType_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtXT_DefindcodeType_Initialized, false);
            AddObjectProperty("XT_DefindcodeTypeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z), 18, 0)), false);
            AddObjectProperty("XT_DefindcodeTypeName_Z", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z, false);
            AddObjectProperty("XT_DefindcodeTypeIsShow_Z", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z, false);
            AddObjectProperty("XT_DefindcodeTypeName_N", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N, false);
            AddObjectProperty("XT_DefindcodeTypeIsShow_N", gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtXT_DefindcodeType sdt )
      {
         if ( sdt.IsDirty("XT_DefindcodeTypeID") )
         {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid ;
         }
         if ( sdt.IsDirty("XT_DefindcodeTypeName") )
         {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename ;
         }
         if ( sdt.IsDirty("XT_DefindcodeTypeIsShow") )
         {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow = sdt.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeID" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeID"   )]
      public long gxTpr_Xt_defindcodetypeid
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid ;
         }

         set {
            if ( gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid != value )
            {
               gxTv_SdtXT_DefindcodeType_Mode = "INS";
               this.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z_SetNull( );
               this.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z_SetNull( );
               this.gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z_SetNull( );
            }
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid = value;
            SetDirty("Xt_defindcodetypeid");
         }

      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName"   )]
      public String gxTpr_Xt_defindcodetypename
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N = 0;
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename = value;
            SetDirty("Xt_defindcodetypename");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N = 1;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeIsShow" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeIsShow"   )]
      public short gxTpr_Xt_defindcodetypeisshow
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N = 0;
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow = value;
            SetDirty("Xt_defindcodetypeisshow");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N = 1;
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Mode ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Mode_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Mode = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Initialized ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Initialized_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeID_Z" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeID_Z"   )]
      public long gxTpr_Xt_defindcodetypeid_Z
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z = value;
            SetDirty("Xt_defindcodetypeid_Z");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName_Z" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName_Z"   )]
      public String gxTpr_Xt_defindcodetypename_Z
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z = value;
            SetDirty("Xt_defindcodetypename_Z");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeIsShow_Z" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeIsShow_Z"   )]
      public short gxTpr_Xt_defindcodetypeisshow_Z
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z = value;
            SetDirty("Xt_defindcodetypeisshow_Z");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeName_N" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeName_N"   )]
      public short gxTpr_Xt_defindcodetypename_N
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N = value;
            SetDirty("Xt_defindcodetypename_N");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_DefindcodeTypeIsShow_N" )]
      [  XmlElement( ElementName = "XT_DefindcodeTypeIsShow_N"   )]
      public short gxTpr_Xt_defindcodetypeisshow_N
      {
         get {
            return gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N ;
         }

         set {
            gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N = value;
            SetDirty("Xt_defindcodetypeisshow_N");
         }

      }

      public void gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N_SetNull( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename = "";
         gxTv_SdtXT_DefindcodeType_Mode = "";
         gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "xt_defindcodetype", "GeneXus.Programs.xt_defindcodetype_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow ;
      private short gxTv_SdtXT_DefindcodeType_Initialized ;
      private short gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_Z ;
      private short gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_N ;
      private short gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeisshow_N ;
      private long gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid ;
      private long gxTv_SdtXT_DefindcodeType_Xt_defindcodetypeid_Z ;
      private String gxTv_SdtXT_DefindcodeType_Mode ;
      private String gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename ;
      private String gxTv_SdtXT_DefindcodeType_Xt_defindcodetypename_Z ;
   }

   [DataContract(Name = @"XT_DefindcodeType", Namespace = "DataAnalysisPlatform")]
   public class SdtXT_DefindcodeType_RESTInterface : GxGenericCollectionItem<SdtXT_DefindcodeType>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_DefindcodeType_RESTInterface( ) : base()
      {
      }

      public SdtXT_DefindcodeType_RESTInterface( SdtXT_DefindcodeType psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "XT_DefindcodeTypeID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Xt_defindcodetypeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_defindcodetypeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_defindcodetypeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_DefindcodeTypeName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Xt_defindcodetypename
      {
         get {
            return sdt.gxTpr_Xt_defindcodetypename ;
         }

         set {
            sdt.gxTpr_Xt_defindcodetypename = value;
         }

      }

      [DataMember( Name = "XT_DefindcodeTypeIsShow" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Xt_defindcodetypeisshow
      {
         get {
            return sdt.gxTpr_Xt_defindcodetypeisshow ;
         }

         set {
            sdt.gxTpr_Xt_defindcodetypeisshow = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtXT_DefindcodeType sdt
      {
         get {
            return (SdtXT_DefindcodeType)Sdt ;
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
            sdt = new SdtXT_DefindcodeType() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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
