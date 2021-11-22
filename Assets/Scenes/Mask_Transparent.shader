Shader "Unlit/Mask_Transparent"
{
    Properties
    {

    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }

        Pass
        {
            ZWrite off
        }
    }
}
