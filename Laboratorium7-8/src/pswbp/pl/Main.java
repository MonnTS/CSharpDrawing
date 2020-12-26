package pswbp.pl;

import org.eclipse.swt.widgets.Display;

public class Main {

    public static void main(String[] args){
        //TODO: Implement display here
        CalculatorFrame frame = new CalculatorFrame();

        while (!frame.s.isDisposed()) {
            if (!frame.d.readAndDispatch())
            { frame.d.sleep();}
        }
        frame.d.dispose();
    }
}