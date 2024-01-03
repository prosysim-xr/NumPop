Shader "Custom/ShapeMask"
{
    Properties 
    {
        _StencilRef ("Stencil Reference", Range(0, 255)) = 244
    }
    SubShader
    {
        Tags {"RenderType"="Opaque" "Queue" = "Transparent+1"}
        ColorMask 0
        ZWrite off
        Stencil
        {
            Ref [_StencilRef]
            Pass replace
        }
	    
        Pass
        {
            Blend Zero One
        }
    }
}
