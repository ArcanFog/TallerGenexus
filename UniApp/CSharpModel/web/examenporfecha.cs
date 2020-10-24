/*
               File: ExamenPorFecha
        Description: Examen Por Fecha
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/24/2020 10:51:48.1
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class examenporfecha : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public examenporfecha( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public examenporfecha( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynExamenFecha = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA172( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START172( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 129648), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202010241051483", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("examenporfecha.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "ExamenPorFecha";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A26ExamenFecha, "99/99/99");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("examenporfecha:[SendSecurityCheck value for]"+"ExamenFecha:"+context.localUtil.Format(A26ExamenFecha, "99/99/99"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE172( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT172( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("examenporfecha.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ExamenPorFecha" ;
      }

      public override String GetPgmdesc( )
      {
         return "Examen Por Fecha" ;
      }

      protected void WB170( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynExamenFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynExamenFecha_Internalname, "Examen Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynExamenFecha, dynExamenFecha_Internalname, context.localUtil.DToC( A26ExamenFecha, 0, "/"), 1, dynExamenFecha_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "date", "", 1, dynExamenFecha.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_ExamenPorFecha.htm");
            dynExamenFecha.CurrentValue = context.localUtil.DToC( A26ExamenFecha, 0, "/");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynExamenFecha_Internalname, "Values", (String)(dynExamenFecha.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBuscar_Internalname, "", "Buscar", bttBuscar_Jsonclick, 5, "Buscar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BUSCAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ExamenPorFecha.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START172( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_1-129648", 0) ;
            Form.Meta.addItem("description", "Examen Por Fecha", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP170( ) ;
      }

      protected void WS172( )
      {
         START172( ) ;
         EVT172( ) ;
      }

      protected void EVT172( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Buscar' */
                              E11172 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E12172 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE172( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA172( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLAEXAMENFECHA171( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAEXAMENFECHA_data171( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXAEXAMENFECHA_html171( )
      {
         DateTime gxdynajaxvalue ;
         GXDLAEXAMENFECHA_data171( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynExamenFecha.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = context.localUtil.CToD( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), 1);
            dynExamenFecha.addItem(context.localUtil.DToC( gxdynajaxvalue, 0, "/"), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAEXAMENFECHA_data171( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00172 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(context.localUtil.Format(H00172_A26ExamenFecha[0], "99/99/99"));
            gxdynajaxctrldescr.Add(context.localUtil.Format(H00172_A26ExamenFecha[0], "99/99/99"));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynExamenFecha.Name = "EXAMENFECHA";
            dynExamenFecha.WebTags = "";
            dynExamenFecha.removeAllItems();
            /* Using cursor H00173 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               dynExamenFecha.addItem(context.localUtil.DToC( H00173_A26ExamenFecha[0], 0, "/"), context.localUtil.Format(H00173_A26ExamenFecha[0], "99/99/99"), 0);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( dynExamenFecha.ItemCount > 0 )
            {
               A26ExamenFecha = context.localUtil.CToD( dynExamenFecha.getValidValue(context.localUtil.DToC( A26ExamenFecha, 0, "/")), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
            }
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynExamenFecha.ItemCount > 0 )
         {
            A26ExamenFecha = context.localUtil.CToD( dynExamenFecha.getValidValue(context.localUtil.DToC( A26ExamenFecha, 0, "/")), 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynExamenFecha.CurrentValue = context.localUtil.DToC( A26ExamenFecha, 0, "/");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynExamenFecha_Internalname, "Values", dynExamenFecha.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF172( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF172( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00174 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               A26ExamenFecha = H00174_A26ExamenFecha[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
               /* Execute user event: Load */
               E12172 ();
               pr_default.readNext(2);
            }
            pr_default.close(2);
            WB170( ) ;
         }
      }

      protected void send_integrity_lvl_hashes172( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
      }

      protected void STRUP170( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynExamenFecha.CurrentValue = cgiGet( dynExamenFecha_Internalname);
            A26ExamenFecha = context.localUtil.CToD( cgiGet( dynExamenFecha_Internalname), 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "ExamenPorFecha";
            A26ExamenFecha = context.localUtil.CToD( cgiGet( dynExamenFecha_Internalname), 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A26ExamenFecha, "99/99/99");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("examenporfecha:[SecurityCheckFailed value for]"+"ExamenFecha:"+context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11172( )
      {
         /* 'Buscar' Routine */
         CallWebObject(formatLink("aexamenes.aspx") + "?" + UrlEncode(DateTimeUtil.FormatDateParm(A26ExamenFecha)));
         context.wjLocDisableFrm = 0;
      }

      protected void nextLoad( )
      {
      }

      protected void E12172( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA172( ) ;
         WS172( ) ;
         WE172( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020102410514819", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("examenporfecha.js", "?2020102410514819", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynExamenFecha.Name = "EXAMENFECHA";
         dynExamenFecha.WebTags = "";
         dynExamenFecha.removeAllItems();
         /* Using cursor H00175 */
         pr_default.execute(3);
         while ( (pr_default.getStatus(3) != 101) )
         {
            dynExamenFecha.addItem(context.localUtil.DToC( H00175_A26ExamenFecha[0], 0, "/"), context.localUtil.Format(H00175_A26ExamenFecha[0], "99/99/99"), 0);
            pr_default.readNext(3);
         }
         pr_default.close(3);
         if ( dynExamenFecha.ItemCount > 0 )
         {
            A26ExamenFecha = context.localUtil.CToD( dynExamenFecha.getValidValue(context.localUtil.DToC( A26ExamenFecha, 0, "/")), 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EXAMENFECHA", GetSecureSignedToken( "", A26ExamenFecha, context));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         dynExamenFecha_Internalname = "EXAMENFECHA";
         bttBuscar_Internalname = "BUSCAR";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         dynExamenFecha_Jsonclick = "";
         dynExamenFecha.Enabled = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Examen Por Fecha";
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'dynExamenFecha'},{av:'A26ExamenFecha',fld:'EXAMENFECHA',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynExamenFecha'},{av:'A26ExamenFecha',fld:'EXAMENFECHA',pic:'',hsh:true}]}");
         setEventMetadata("'BUSCAR'","{handler:'E11172',iparms:[{av:'dynExamenFecha'},{av:'A26ExamenFecha',fld:'EXAMENFECHA',pic:'',hsh:true}]");
         setEventMetadata("'BUSCAR'",",oparms:[{av:'dynExamenFecha'},{av:'A26ExamenFecha',fld:'EXAMENFECHA',pic:'',hsh:true}]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         A26ExamenFecha = DateTime.MinValue;
         GXKey = "";
         forbiddenHiddens = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBuscar_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H00172_A17ExamenId = new short[1] ;
         H00172_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         H00173_A17ExamenId = new short[1] ;
         H00173_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         H00174_A17ExamenId = new short[1] ;
         H00174_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         hsh = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         H00175_A17ExamenId = new short[1] ;
         H00175_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.examenporfecha__default(),
            new Object[][] {
                new Object[] {
               H00172_A17ExamenId, H00172_A26ExamenFecha
               }
               , new Object[] {
               H00173_A17ExamenId, H00173_A26ExamenFecha
               }
               , new Object[] {
               H00174_A17ExamenId, H00174_A26ExamenFecha
               }
               , new Object[] {
               H00175_A17ExamenId, H00175_A26ExamenFecha
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String dynExamenFecha_Internalname ;
      private String dynExamenFecha_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBuscar_Internalname ;
      private String bttBuscar_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String hsh ;
      private DateTime A26ExamenFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynExamenFecha ;
      private IDataStoreProvider pr_default ;
      private short[] H00172_A17ExamenId ;
      private DateTime[] H00172_A26ExamenFecha ;
      private short[] H00173_A17ExamenId ;
      private DateTime[] H00173_A26ExamenFecha ;
      private short[] H00174_A17ExamenId ;
      private DateTime[] H00174_A26ExamenFecha ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short[] H00175_A17ExamenId ;
      private DateTime[] H00175_A26ExamenFecha ;
      private GXWebForm Form ;
   }

   public class examenporfecha__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00172 ;
          prmH00172 = new Object[] {
          } ;
          Object[] prmH00173 ;
          prmH00173 = new Object[] {
          } ;
          Object[] prmH00174 ;
          prmH00174 = new Object[] {
          } ;
          Object[] prmH00175 ;
          prmH00175 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00172", "SELECT [ExamenId], [ExamenFecha] FROM [Examen] WITH (NOLOCK) ORDER BY [ExamenFecha] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00172,0,0,true,false )
             ,new CursorDef("H00173", "SELECT [ExamenId], [ExamenFecha] FROM [Examen] WITH (NOLOCK) ORDER BY [ExamenFecha] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00173,0,0,true,false )
             ,new CursorDef("H00174", "SELECT [ExamenId], [ExamenFecha] FROM [Examen] WITH (NOLOCK) ORDER BY [ExamenId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00174,100,0,true,false )
             ,new CursorDef("H00175", "SELECT [ExamenId], [ExamenFecha] FROM [Examen] WITH (NOLOCK) ORDER BY [ExamenFecha] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00175,0,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
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
