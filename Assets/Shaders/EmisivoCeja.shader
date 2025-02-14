// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33139,y:32383,varname:node_9361,prsc:2|emission-3245-OUT;n:type:ShaderForge.SFN_Time,id:7999,x:31965,y:32673,varname:node_7999,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6102,x:32216,y:32607,varname:node_6102,prsc:2|A-6718-OUT,B-7999-T;n:type:ShaderForge.SFN_Sin,id:2606,x:32433,y:32607,varname:node_2606,prsc:2|IN-6102-OUT;n:type:ShaderForge.SFN_RemapRange,id:4116,x:32653,y:32607,varname:node_4116,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-2606-OUT;n:type:ShaderForge.SFN_Lerp,id:3245,x:32877,y:32531,varname:node_3245,prsc:2|A-4669-RGB,B-2770-RGB,T-4116-OUT;n:type:ShaderForge.SFN_Color,id:2770,x:32653,y:32396,ptovrint:False,ptlb:node_2770,ptin:_node_2770,varname:node_2770,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9852941,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:4669,x:32653,y:32191,ptovrint:False,ptlb:node_4669,ptin:_node_4669,varname:node_4669,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:6718,x:31965,y:32562,ptovrint:False,ptlb:Lerp Speed,ptin:_LerpSpeed,varname:node_6718,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;proporder:2770-4669-6718;pass:END;sub:END;*/

Shader "Shader Forge/EmisivoCeja" {
    Properties {
        _node_2770 ("node_2770", Color) = (0.9852941,1,0,1)
        _node_4669 ("node_4669", Color) = (1,0,0,1)
        _LerpSpeed ("Lerp Speed", Float ) = 3
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _node_2770;
            uniform float4 _node_4669;
            uniform float _LerpSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_7999 = _Time;
                float3 emissive = lerp(_node_4669.rgb,_node_2770.rgb,(sin((_LerpSpeed*node_7999.g))*0.5+0.5));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
