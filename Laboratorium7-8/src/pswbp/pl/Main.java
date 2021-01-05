package pswbp.pl;

public class Main {

    public static void main(String[] args){

        CalculatorFrame cf = new CalculatorFrame();

        while(!cf.S.isDisposed()){
            if(!cf.D.readAndDispatch()){
                cf.D.sleep();
            }
        }
        cf.D.dispose();
    }
}