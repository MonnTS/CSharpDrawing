package pswbp.pl;

import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.*;

public class Messages {

    public MessageBox ErrorOnAge;
    public MessageBox ErrorOnVoid;
    public MessageBox ErrorOnSex;

    public Messages(CalculatorFrame cf){
        ErrorOnAge = new MessageBox(cf.S, SWT.ICON_WARNING);
        ErrorOnAge.setText("Error on age");
        ErrorOnAge.setMessage("Your age can't be equals 0");

        ErrorOnVoid = new MessageBox(cf.S, SWT.ICON_WARNING);
        ErrorOnVoid.setText("Empty Error");
        ErrorOnVoid.setMessage("Everything is empty." +
                " Provide data!");

        ErrorOnSex = new MessageBox(cf.S, SWT.ICON_WARNING);
        ErrorOnSex.setText("Error on sex");
        ErrorOnSex.setMessage("What are you...?");
    }

    public void NotTrueAge(){
        ErrorOnAge.open();
    }

    public void AllEmpty(){
        ErrorOnVoid.open();
    }

    public void NotTrueSex(){
        ErrorOnSex.open();
    }
}