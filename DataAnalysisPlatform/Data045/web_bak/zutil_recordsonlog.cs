/*
               File: ZUtil_RecordSonLog
        Description: 记录子模块日志的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:2.99
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zutil_recordsonlog : GXProcedure
   {
      public zutil_recordsonlog( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_recordsonlog( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_iXT_LogTarget ,
                           String aP1_iXT_LogTargetModule ,
                           String aP2_iXT_LogSonTarget ,
                           String aP3_iXT_LogTargetSonModule ,
                           String aP4_iXT_LogTargetOperate ,
                           short aP5_tOperateType )
      {
         this.AV9iXT_LogTarget = aP0_iXT_LogTarget;
         this.AV10iXT_LogTargetModule = aP1_iXT_LogTargetModule;
         this.AV15iXT_LogSonTarget = aP2_iXT_LogSonTarget;
         this.AV16iXT_LogTargetSonModule = aP3_iXT_LogTargetSonModule;
         this.AV11iXT_LogTargetOperate = aP4_iXT_LogTargetOperate;
         this.AV14tOperateType = aP5_tOperateType;
         initialize();
         executePrivate();
      }

      public void executeSubmit( String aP0_iXT_LogTarget ,
                                 String aP1_iXT_LogTargetModule ,
                                 String aP2_iXT_LogSonTarget ,
                                 String aP3_iXT_LogTargetSonModule ,
                                 String aP4_iXT_LogTargetOperate ,
                                 short aP5_tOperateType )
      {
         zutil_recordsonlog objzutil_recordsonlog;
         objzutil_recordsonlog = new zutil_recordsonlog();
         objzutil_recordsonlog.AV9iXT_LogTarget = aP0_iXT_LogTarget;
         objzutil_recordsonlog.AV10iXT_LogTargetModule = aP1_iXT_LogTargetModule;
         objzutil_recordsonlog.AV15iXT_LogSonTarget = aP2_iXT_LogSonTarget;
         objzutil_recordsonlog.AV16iXT_LogTargetSonModule = aP3_iXT_LogTargetSonModule;
         objzutil_recordsonlog.AV11iXT_LogTargetOperate = aP4_iXT_LogTargetOperate;
         objzutil_recordsonlog.AV14tOperateType = aP5_tOperateType;
         objzutil_recordsonlog.context.SetSubmitInitialConfig(context);
         objzutil_recordsonlog.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_recordsonlog);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_recordsonlog)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV12WWPContext) ;
         AV17BCSYS_Log.gxTpr_Sys_logcreator = AV12WWPContext.gxTpr_Userguid;
         AV17BCSYS_Log.gxTpr_Sys_logcreatetime = DateTimeUtil.ServerNow( context, pr_default);
         GXt_char1 = "";
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV17BCSYS_Log.gxTpr_Sys_logtenantcode = GXt_char1;
         AV17BCSYS_Log.gxTpr_Sys_logmodulecode = "Data Management";
         AV17BCSYS_Log.gxTpr_Sys_logclientip = AV12WWPContext.gxTpr_Clientip;
         if ( AV14tOperateType == 1 )
         {
            AV17BCSYS_Log.gxTpr_Sys_logtitle = gxdomaindm_logoperatetype.getDescription(context,AV11iXT_LogTargetOperate)+StringUtil.Trim( AV16iXT_LogTargetSonModule)+":"+StringUtil.Trim( AV15iXT_LogSonTarget);
            AV17BCSYS_Log.gxTpr_Sys_loglogtype = AV11iXT_LogTargetOperate;
            AV17BCSYS_Log.gxTpr_Sys_logcontent = "对"+StringUtil.Trim( AV10iXT_LogTargetModule)+StringUtil.Trim( AV9iXT_LogTarget)+"中"+StringUtil.Trim( AV16iXT_LogTargetSonModule)+"的"+StringUtil.Trim( AV15iXT_LogSonTarget)+"进行了"+gxdomaindm_logoperatetype.getDescription(context,AV11iXT_LogTargetOperate)+"操作";
         }
         AV17BCSYS_Log.Save();
         if ( AV17BCSYS_Log.Fail() )
         {
            GX_msglist.addItem("日志保存失败");
         }
         else
         {
            context.CommitDataStores("zutil_recordsonlog",pr_default);
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV12WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17BCSYS_Log = new SdtSYS_Log(context);
         GXt_char1 = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.zutil_recordsonlog__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_recordsonlog__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV14tOperateType ;
      private String GXt_char1 ;
      private String AV9iXT_LogTarget ;
      private String AV10iXT_LogTargetModule ;
      private String AV15iXT_LogSonTarget ;
      private String AV16iXT_LogTargetSonModule ;
      private String AV11iXT_LogTargetOperate ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV12WWPContext ;
      private SdtSYS_Log AV17BCSYS_Log ;
   }

   public class zutil_recordsonlog__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class zutil_recordsonlog__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
