namespace EtlKit;

public class Pipeline<TSource, TSink>
{
    public Pipeline<TSource, TSink> AddSource(Stream inputStream) 
    {
        return this;
    }

    public Pipeline<TSource, TSink> AddSink(Stream inputStream) 
    {
        return this;
    }    
}