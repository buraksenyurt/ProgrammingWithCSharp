namespace Learning.Structs
{
    public struct ComplexNumber(float real, float imaginary)
    {
        public float Real { get; set; } = real;
        public float Imaginary { get; set; } = imaginary;

        //TODO@buraksenyurt Add ve Multiply operasyonları operator overloading ile karşılanabilir
        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            return new ComplexNumber(
                this.Real * other.Real - this.Imaginary * other.Imaginary,
                this.Real * other.Imaginary + this.Imaginary * other.Real
            );
        }
        public override string ToString()
        {
            return $"{Real:F2} + ({Imaginary})i";
        }
    }
}
