// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:0,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:32719,y:32712,varname:node_4013,prsc:2|emission-8462-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32230,y:32670,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.6911764,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:6562,x:32024,y:33042,varname:node_6562,prsc:2|EXP-4563-OUT;n:type:ShaderForge.SFN_Slider,id:4563,x:31612,y:33072,ptovrint:False,ptlb:Fresnel Strench,ptin:_FresnelStrench,varname:node_4563,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6546642,max:1;n:type:ShaderForge.SFN_Slider,id:2934,x:31867,y:33250,ptovrint:False,ptlb:Transparent,ptin:_Transparent,varname:node_2934,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4642657,max:1;n:type:ShaderForge.SFN_Multiply,id:8394,x:32239,y:33042,varname:node_8394,prsc:2|A-8242-RGB,B-6562-OUT,C-2934-OUT;n:type:ShaderForge.SFN_Tex2d,id:8242,x:32024,y:32843,ptovrint:False,ptlb:node_8242,ptin:_node_8242,varname:node_8242,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3917d9a686bee9b4f9c8ec69a4b4a01e,ntxv:2,isnm:False|UVIN-887-UVOUT;n:type:ShaderForge.SFN_Time,id:7621,x:30823,y:32772,varname:node_7621,prsc:2;n:type:ShaderForge.SFN_Slider,id:537,x:30692,y:32966,ptovrint:False,ptlb:UOffset,ptin:_UOffset,varname:node_537,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Panner,id:8457,x:31142,y:32701,varname:node_8457,prsc:2,spu:1,spv:0|UVIN-9868-UVOUT,DIST-4858-OUT;n:type:ShaderForge.SFN_Multiply,id:4858,x:31040,y:32934,varname:node_4858,prsc:2|A-7621-T,B-537-OUT;n:type:ShaderForge.SFN_TexCoord,id:9868,x:30823,y:32564,varname:node_9868,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:887,x:31388,y:32887,varname:node_887,prsc:2,spu:0,spv:1|UVIN-8457-UVOUT,DIST-8739-OUT;n:type:ShaderForge.SFN_Multiply,id:8739,x:31040,y:33086,varname:node_8739,prsc:2|A-7621-T,B-7142-OUT;n:type:ShaderForge.SFN_Slider,id:7142,x:30692,y:33129,ptovrint:False,ptlb:VOffset,ptin:_VOffset,varname:node_7142,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3463093,max:1;n:type:ShaderForge.SFN_SceneColor,id:4856,x:32017,y:32500,varname:node_4856,prsc:2;n:type:ShaderForge.SFN_Clamp01,id:798,x:32230,y:32500,varname:node_798,prsc:2|IN-4856-RGB;n:type:ShaderForge.SFN_Lerp,id:8462,x:32483,y:32741,varname:node_8462,prsc:2|A-798-OUT,B-1304-RGB,T-493-OUT;n:type:ShaderForge.SFN_Tex2d,id:899,x:32239,y:32843,ptovrint:False,ptlb:node_899,ptin:_node_899,varname:node_899,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2c359d1fdd30585479fc3d3483ae81c8,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Add,id:493,x:32428,y:32906,varname:node_493,prsc:2|A-899-A,B-8394-OUT;proporder:1304-4563-2934-8242-537-7142-899;pass:END;sub:END;*/

Shader "Shader Forge/PlayerShield" {
    Properties {
        _Color ("Color", Color) = (0,0.6911764,1,1)
        _FresnelStrench ("Fresnel Strench", Range(0, 1)) = 0.6546642
        _Transparent ("Transparent", Range(0, 1)) = 0.4642657
        _node_8242 ("node_8242", 2D) = "black" {}
        _UOffset ("UOffset", Range(0, 1)) = 0
        _VOffset ("VOffset", Range(0, 1)) = 0.3463093
        _node_899 ("node_899", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform float _FresnelStrench;
            uniform float _Transparent;
            uniform sampler2D _node_8242; uniform float4 _node_8242_ST;
            uniform float _UOffset;
            uniform float _VOffset;
            uniform sampler2D _node_899; uniform float4 _node_899_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
////// Emissive:
                float4 _node_899_var = tex2D(_node_899,TRANSFORM_TEX(i.uv0, _node_899));
                float4 node_7621 = _Time;
                float2 node_887 = ((i.uv0+(node_7621.g*_UOffset)*float2(1,0))+(node_7621.g*_VOffset)*float2(0,1));
                float4 _node_8242_var = tex2D(_node_8242,TRANSFORM_TEX(node_887, _node_8242));
                float3 emissive = lerp(saturate(sceneColor.rgb),_Color.rgb,(_node_899_var.a+(_node_8242_var.rgb*pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelStrench)*_Transparent)));
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
