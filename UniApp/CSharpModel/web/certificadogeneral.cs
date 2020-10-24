/*
               File: CertificadoGeneral
        Description: Certificado General
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:46.45
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class certificadogeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public certificadogeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public certificadogeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_CertificadoId )
      {
         this.A16CertificadoId = aP0_CertificadoId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A16CertificadoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A16CertificadoId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0V2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "CertificadoGeneral";
               context.Gx_err = 0;
               WS0V2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Certificado General") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 129648), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxcfg.js", "?2020101711154651", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 129648), false, true);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("certificadogeneral.aspx") + "?" + UrlEncode("" +A16CertificadoId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = sPrefix + "hsh" + "CertificadoGeneral";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9");
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("certificadogeneral:[SendSecurityCheck value for]"+"ExamenId:"+context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9"));
         GXUtil.WriteLog("certificadogeneral:[SendSecurityCheck value for]"+"EstudianteId:"+context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA16CertificadoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA16CertificadoId), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm0V2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("certificadogeneral.js", "?2020101711154654", false, true);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "CertificadoGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Certificado General" ;
      }

      protected void WB0V0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "certificadogeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110v1_client"+"'", TempTags, "", 2, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120v1_client"+"'", TempTags, "", 2, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCertificadoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCertificadoId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCertificadoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16CertificadoId), 4, 0, ".", "")), ((edtCertificadoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16CertificadoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A16CertificadoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCertificadoId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCertificadoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCertificadoFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCertificadoFecha_Internalname, "Fecha", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtCertificadoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCertificadoFecha_Internalname, context.localUtil.Format(A28CertificadoFecha, "99/99/99"), context.localUtil.Format( A28CertificadoFecha, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCertificadoFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCertificadoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_bitmap( context, edtCertificadoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtCertificadoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_CertificadoGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenId_Internalname, "Examen Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ExamenId), 4, 0, ".", "")), ((edtExamenId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9")) : context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenFecha_Internalname, "Examen Fecha", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtExamenFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtExamenFecha_Internalname, context.localUtil.Format(A26ExamenFecha, "99/99/99"), context.localUtil.Format( A26ExamenFecha, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtExamenFecha_Link, "", "", "", edtExamenFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_bitmap( context, edtExamenFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtExamenFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_CertificadoGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraId_Internalname, "Examen Carr Asig Carrera Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")), ((edtExamenCarrAsigCarreraId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22ExamenCarrAsigCarreraId), "ZZZ9")) : context.localUtil.Format( (decimal)(A22ExamenCarrAsigCarreraId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenCarrAsigCarreraId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraNombre_Internalname, "Examen Carr Asig Carrera Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraNombre_Internalname, StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre), StringUtil.RTrim( context.localUtil.Format( A23ExamenCarrAsigCarreraNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenCarrAsigCarreraNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaId_Internalname, "Examen Carr Asig Asignatura Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")), ((edtExamenCarrAsigAsignaturaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A24ExamenCarrAsigAsignaturaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A24ExamenCarrAsigAsignaturaId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaNombre_Internalname, "Examen Carr Asig Asignatura Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaNombre_Internalname, StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A25ExamenCarrAsigAsignaturaNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteId_Internalname, "Estudiante Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEstudianteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")), ((edtEstudianteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9")) : context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEstudianteId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteNombre_Internalname, "Estudiante Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEstudianteNombre_Internalname, StringUtil.RTrim( A18EstudianteNombre), StringUtil.RTrim( context.localUtil.Format( A18EstudianteNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtEstudianteNombre_Link, "", "", "", edtEstudianteNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEstudianteNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenEstudianteNota_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenEstudianteNota_Internalname, "Examen Estudiante Nota", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenEstudianteNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")), ((edtExamenEstudianteNota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")) : context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenEstudianteNota_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtExamenEstudianteNota_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CertificadoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0V2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_1-129648", 0) ;
               Form.Meta.addItem("description", "Certificado General", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0V0( ) ;
            }
         }
      }

      protected void WS0V2( )
      {
         START0V2( ) ;
         EVT0V2( ) ;
      }

      protected void EVT0V2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130V2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140V2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
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

      protected void WE0V2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0V2( ) ;
            }
         }
      }

      protected void PA0V2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
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

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0V2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "CertificadoGeneral";
         context.Gx_err = 0;
      }

      protected void RF0V2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000V2 */
            pr_default.execute(0, new Object[] {A16CertificadoId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A27ExamenEstudianteNota = H000V2_A27ExamenEstudianteNota[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
               A18EstudianteNombre = H000V2_A18EstudianteNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18EstudianteNombre", A18EstudianteNombre);
               A15EstudianteId = H000V2_A15EstudianteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               A25ExamenCarrAsigAsignaturaNombre = H000V2_A25ExamenCarrAsigAsignaturaNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
               A24ExamenCarrAsigAsignaturaId = H000V2_A24ExamenCarrAsigAsignaturaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
               A23ExamenCarrAsigCarreraNombre = H000V2_A23ExamenCarrAsigCarreraNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
               A22ExamenCarrAsigCarreraId = H000V2_A22ExamenCarrAsigCarreraId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
               A26ExamenFecha = H000V2_A26ExamenFecha[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               A17ExamenId = H000V2_A17ExamenId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               A28CertificadoFecha = H000V2_A28CertificadoFecha[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
               A18EstudianteNombre = H000V2_A18EstudianteNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18EstudianteNombre", A18EstudianteNombre);
               A24ExamenCarrAsigAsignaturaId = H000V2_A24ExamenCarrAsigAsignaturaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
               A22ExamenCarrAsigCarreraId = H000V2_A22ExamenCarrAsigCarreraId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
               A26ExamenFecha = H000V2_A26ExamenFecha[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               A23ExamenCarrAsigCarreraNombre = H000V2_A23ExamenCarrAsigCarreraNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
               A25ExamenCarrAsigAsignaturaNombre = H000V2_A25ExamenCarrAsigAsignaturaNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
               A27ExamenEstudianteNota = H000V2_A27ExamenEstudianteNota[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
               /* Execute user event: Load */
               E140V2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0V0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0V2( )
      {
      }

      protected void STRUP0V0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "CertificadoGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130V2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A28CertificadoFecha = context.localUtil.CToD( cgiGet( edtCertificadoFecha_Internalname), 1);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A28CertificadoFecha", context.localUtil.Format(A28CertificadoFecha, "99/99/99"));
            A17ExamenId = (short)(context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            A26ExamenFecha = context.localUtil.CToD( cgiGet( edtExamenFecha_Internalname), 1);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A22ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigCarreraId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A23ExamenCarrAsigCarreraNombre = cgiGet( edtExamenCarrAsigCarreraNombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            A24ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigAsignaturaId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            A25ExamenCarrAsigAsignaturaNombre = cgiGet( edtExamenCarrAsigAsignaturaNombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            A15EstudianteId = (short)(context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            A18EstudianteNombre = cgiGet( edtEstudianteNombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18EstudianteNombre", A18EstudianteNombre);
            A27ExamenEstudianteNota = (short)(context.localUtil.CToN( cgiGet( edtExamenEstudianteNota_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27ExamenEstudianteNota", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ExamenEstudianteNota), 4, 0)));
            /* Read saved values. */
            wcpOA16CertificadoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA16CertificadoId"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "CertificadoGeneral";
            A17ExamenId = (short)(context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9");
            A15EstudianteId = (short)(context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9");
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("certificadogeneral:[SecurityCheckFailed value for]"+"ExamenId:"+context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9"));
               GXUtil.WriteLog("certificadogeneral:[SecurityCheckFailed value for]"+"EstudianteId:"+context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9"));
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

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E130V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130V2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E140V2( )
      {
         /* Load Routine */
         edtExamenFecha_Link = formatLink("viewexamen.aspx") + "?" + UrlEncode("" +A17ExamenId) + "," + UrlEncode(StringUtil.RTrim(""));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtExamenFecha_Internalname, "Link", edtExamenFecha_Link, true);
         edtEstudianteNombre_Link = formatLink("viewestudiante.aspx") + "?" + UrlEncode("" +A15EstudianteId) + "," + UrlEncode(StringUtil.RTrim(""));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtEstudianteNombre_Internalname, "Link", edtEstudianteNombre_Link, true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Certificado";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "CertificadoId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6CertificadoId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "UniApp"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A16CertificadoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
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
         PA0V2( ) ;
         WS0V2( ) ;
         WE0V2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA16CertificadoId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0V2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "certificadogeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0V2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A16CertificadoId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         }
         wcpOA16CertificadoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA16CertificadoId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A16CertificadoId != wcpOA16CertificadoId ) ) )
         {
            setjustcreated();
         }
         wcpOA16CertificadoId = A16CertificadoId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA16CertificadoId = cgiGet( sPrefix+"A16CertificadoId_CTRL");
         if ( StringUtil.Len( sCtrlA16CertificadoId) > 0 )
         {
            A16CertificadoId = (short)(context.localUtil.CToN( cgiGet( sCtrlA16CertificadoId), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16CertificadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16CertificadoId), 4, 0)));
         }
         else
         {
            A16CertificadoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A16CertificadoId_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0V2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0V2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0V2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A16CertificadoId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16CertificadoId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA16CertificadoId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A16CertificadoId_CTRL", StringUtil.RTrim( sCtrlA16CertificadoId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0V2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101711154770", true, true);
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
         context.AddJavascriptSource("certificadogeneral.js", "?2020101711154770", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtCertificadoId_Internalname = sPrefix+"CERTIFICADOID";
         edtCertificadoFecha_Internalname = sPrefix+"CERTIFICADOFECHA";
         edtExamenId_Internalname = sPrefix+"EXAMENID";
         edtExamenFecha_Internalname = sPrefix+"EXAMENFECHA";
         edtExamenCarrAsigCarreraId_Internalname = sPrefix+"EXAMENCARRASIGCARRERAID";
         edtExamenCarrAsigCarreraNombre_Internalname = sPrefix+"EXAMENCARRASIGCARRERANOMBRE";
         edtExamenCarrAsigAsignaturaId_Internalname = sPrefix+"EXAMENCARRASIGASIGNATURAID";
         edtExamenCarrAsigAsignaturaNombre_Internalname = sPrefix+"EXAMENCARRASIGASIGNATURANOMBRE";
         edtEstudianteId_Internalname = sPrefix+"ESTUDIANTEID";
         edtEstudianteNombre_Internalname = sPrefix+"ESTUDIANTENOMBRE";
         edtExamenEstudianteNota_Internalname = sPrefix+"EXAMENESTUDIANTENOTA";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtExamenEstudianteNota_Jsonclick = "";
         edtExamenEstudianteNota_Enabled = 0;
         edtEstudianteNombre_Jsonclick = "";
         edtEstudianteNombre_Link = "";
         edtEstudianteNombre_Enabled = 0;
         edtEstudianteId_Jsonclick = "";
         edtEstudianteId_Enabled = 0;
         edtExamenCarrAsigAsignaturaNombre_Jsonclick = "";
         edtExamenCarrAsigAsignaturaNombre_Enabled = 0;
         edtExamenCarrAsigAsignaturaId_Jsonclick = "";
         edtExamenCarrAsigAsignaturaId_Enabled = 0;
         edtExamenCarrAsigCarreraNombre_Jsonclick = "";
         edtExamenCarrAsigCarreraNombre_Enabled = 0;
         edtExamenCarrAsigCarreraId_Jsonclick = "";
         edtExamenCarrAsigCarreraId_Enabled = 0;
         edtExamenFecha_Jsonclick = "";
         edtExamenFecha_Link = "";
         edtExamenFecha_Enabled = 0;
         edtExamenId_Jsonclick = "";
         edtExamenId_Enabled = 0;
         edtCertificadoFecha_Jsonclick = "";
         edtCertificadoFecha_Enabled = 0;
         edtCertificadoId_Jsonclick = "";
         edtCertificadoId_Enabled = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A17ExamenId',fld:'EXAMENID',pic:'ZZZ9'},{av:'A15EstudianteId',fld:'ESTUDIANTEID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E110V1',iparms:[{av:'A16CertificadoId',fld:'CERTIFICADOID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120V1',iparms:[{av:'A16CertificadoId',fld:'CERTIFICADOID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
         sPrefix = "";
         AV13Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A28CertificadoFecha = DateTime.MinValue;
         A26ExamenFecha = DateTime.MinValue;
         A23ExamenCarrAsigCarreraNombre = "";
         A25ExamenCarrAsigAsignaturaNombre = "";
         A18EstudianteNombre = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000V2_A16CertificadoId = new short[1] ;
         H000V2_A27ExamenEstudianteNota = new short[1] ;
         H000V2_A18EstudianteNombre = new String[] {""} ;
         H000V2_A15EstudianteId = new short[1] ;
         H000V2_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         H000V2_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         H000V2_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         H000V2_A22ExamenCarrAsigCarreraId = new short[1] ;
         H000V2_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         H000V2_A17ExamenId = new short[1] ;
         H000V2_A28CertificadoFecha = new DateTime[] {DateTime.MinValue} ;
         hsh = "";
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA16CertificadoId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.certificadogeneral__default(),
            new Object[][] {
                new Object[] {
               H000V2_A16CertificadoId, H000V2_A27ExamenEstudianteNota, H000V2_A18EstudianteNombre, H000V2_A15EstudianteId, H000V2_A25ExamenCarrAsigAsignaturaNombre, H000V2_A24ExamenCarrAsigAsignaturaId, H000V2_A23ExamenCarrAsigCarreraNombre, H000V2_A22ExamenCarrAsigCarreraId, H000V2_A26ExamenFecha, H000V2_A17ExamenId,
               H000V2_A28CertificadoFecha
               }
            }
         );
         AV13Pgmname = "CertificadoGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "CertificadoGeneral";
         context.Gx_err = 0;
      }

      private short A16CertificadoId ;
      private short wcpOA16CertificadoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short A17ExamenId ;
      private short A15EstudianteId ;
      private short wbEnd ;
      private short wbStart ;
      private short A22ExamenCarrAsigCarreraId ;
      private short A24ExamenCarrAsigAsignaturaId ;
      private short A27ExamenEstudianteNota ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6CertificadoId ;
      private short nGXWrapped ;
      private int edtCertificadoId_Enabled ;
      private int edtCertificadoFecha_Enabled ;
      private int edtExamenId_Enabled ;
      private int edtExamenFecha_Enabled ;
      private int edtExamenCarrAsigCarreraId_Enabled ;
      private int edtExamenCarrAsigCarreraNombre_Enabled ;
      private int edtExamenCarrAsigAsignaturaId_Enabled ;
      private int edtExamenCarrAsigAsignaturaNombre_Enabled ;
      private int edtEstudianteId_Enabled ;
      private int edtEstudianteNombre_Enabled ;
      private int edtExamenEstudianteNota_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV13Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtCertificadoId_Internalname ;
      private String edtCertificadoId_Jsonclick ;
      private String edtCertificadoFecha_Internalname ;
      private String edtCertificadoFecha_Jsonclick ;
      private String edtExamenId_Internalname ;
      private String edtExamenId_Jsonclick ;
      private String edtExamenFecha_Internalname ;
      private String edtExamenFecha_Link ;
      private String edtExamenFecha_Jsonclick ;
      private String edtExamenCarrAsigCarreraId_Internalname ;
      private String edtExamenCarrAsigCarreraId_Jsonclick ;
      private String edtExamenCarrAsigCarreraNombre_Internalname ;
      private String A23ExamenCarrAsigCarreraNombre ;
      private String edtExamenCarrAsigCarreraNombre_Jsonclick ;
      private String edtExamenCarrAsigAsignaturaId_Internalname ;
      private String edtExamenCarrAsigAsignaturaId_Jsonclick ;
      private String edtExamenCarrAsigAsignaturaNombre_Internalname ;
      private String A25ExamenCarrAsigAsignaturaNombre ;
      private String edtExamenCarrAsigAsignaturaNombre_Jsonclick ;
      private String edtEstudianteId_Internalname ;
      private String edtEstudianteId_Jsonclick ;
      private String edtEstudianteNombre_Internalname ;
      private String A18EstudianteNombre ;
      private String edtEstudianteNombre_Link ;
      private String edtEstudianteNombre_Jsonclick ;
      private String edtExamenEstudianteNota_Internalname ;
      private String edtExamenEstudianteNota_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA16CertificadoId ;
      private DateTime A28CertificadoFecha ;
      private DateTime A26ExamenFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000V2_A16CertificadoId ;
      private short[] H000V2_A27ExamenEstudianteNota ;
      private String[] H000V2_A18EstudianteNombre ;
      private short[] H000V2_A15EstudianteId ;
      private String[] H000V2_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] H000V2_A24ExamenCarrAsigAsignaturaId ;
      private String[] H000V2_A23ExamenCarrAsigCarreraNombre ;
      private short[] H000V2_A22ExamenCarrAsigCarreraId ;
      private DateTime[] H000V2_A26ExamenFecha ;
      private short[] H000V2_A17ExamenId ;
      private DateTime[] H000V2_A28CertificadoFecha ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class certificadogeneral__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000V2 ;
          prmH000V2 = new Object[] {
          new Object[] {"@CertificadoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000V2", "SELECT T1.[CertificadoId], T6.[ExamenEstudianteNota], T2.[EstudianteNombre], T1.[EstudianteId], T5.[AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre, T3.[ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId, T4.[CarreraNombre] AS ExamenCarrAsigCarreraNombre, T3.[ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, T3.[ExamenFecha], T1.[ExamenId], T1.[CertificadoFecha] FROM ((((([Certificado] T1 WITH (NOLOCK) INNER JOIN [Estudiante] T2 WITH (NOLOCK) ON T2.[EstudianteId] = T1.[EstudianteId]) INNER JOIN [Examen] T3 WITH (NOLOCK) ON T3.[ExamenId] = T1.[ExamenId]) INNER JOIN [Carrera] T4 WITH (NOLOCK) ON T4.[CarreraId] = T3.[ExamenCarrAsigCarreraId]) INNER JOIN [CarreraAsignatura] T5 WITH (NOLOCK) ON T5.[CarreraId] = T3.[ExamenCarrAsigCarreraId] AND T5.[AsignaturaId] = T3.[ExamenCarrAsigAsignaturaId]) INNER JOIN [ExamenEstudiiante] T6 WITH (NOLOCK) ON T6.[ExamenId] = T1.[ExamenId] AND T6.[EstudianteId] = T1.[EstudianteId]) WHERE T1.[CertificadoId] = @CertificadoId ORDER BY T1.[CertificadoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V2,1,0,true,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 20) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(11) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
