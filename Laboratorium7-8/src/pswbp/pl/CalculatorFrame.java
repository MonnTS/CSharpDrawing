package pswbp.pl;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.*;
import org.eclipse.swt.widgets.*;

public class CalculatorFrame {

    public Shell s;
    public Display d;
    public Text age;
    public Text sex;
    public Text pressure;
    public Text mmol;
    public Text mg;
    public Label _age;
    public Label _sex;
    public Label _pressure;
    public Label _mmol;
    public Label _mgdl;
    public final Button Check;
    public final Button Check1;
    public final Button Smoking;
    public final Button NotSmoking;
    public final Button GetResult;

    public CalculatorFrame()
    {
        //TODO: Make new Christmas theme for the application?
        //TODO: Make buttons next to the text fields(Check, Check1)
        Methods methods = new Methods();

        s = new Shell(d);
        s.setSize(450,310);
        s.setText("Calculator of hysterectomies");
        s.open();

        _age = new Label(s, SWT.SINGLE);
        _age.setText("Age");
        _age.setBounds(10,10,50,20);

        _sex = new Label(s, SWT.SINGLE);
        _sex.setText("Sex");
        _sex.setBounds(10,60,50,20);

        _pressure = new Label(s, SWT.SINGLE);
        _pressure.setText("Pressure");
        _pressure.setBounds(10,115,50,20);

        _mmol = new Label(s, SWT.SINGLE);
        _mmol.setText("mmol/l");
        _mmol.setEnabled(false);
        _mmol.setBounds(10, 170, 50, 20);

        _mgdl = new Label(s, SWT.SINGLE);
        _mgdl.setText("mg/dl");
        _mgdl.setEnabled(false);
        _mgdl.setBounds(110, 170, 50, 20);

        age = new Text(s, SWT.SINGLE | SWT.BORDER);
        age.setBounds(10,35,90,20);

        sex = new Text(s, SWT.SINGLE | SWT.BORDER);
        sex.setBounds(10,85,90,20);

        pressure = new Text(s, SWT.SINGLE | SWT.BORDER);
        pressure.setBounds(10,140,90,20);

        mmol = new Text(s, SWT.SINGLE | SWT.BORDER);
        mmol.setEnabled(false);
        mmol.setBounds(10, 195, 90, 20);

        mg = new Text(s, SWT.SINGLE | SWT.BORDER);
        mg.setEnabled(false);
        mg.setBounds(110, 195, 90, 20);

        Check = new Button(s, SWT.CHECK);
        Check.setText("Calculate in mmol/l");
        Check.setBounds(10,220,130,20);

        Check1 = new Button(s, SWT.CHECK);
        Check1.setText("Calculate in mg/dl");
        Check1.setBounds(10,240,130,20);

        Smoking = new Button(s, SWT.CHECK);
        Smoking.setText("Smoking");
        Smoking.setBounds(150, 220, 90,20);

        NotSmoking = new Button(s, SWT.CHECK);
        NotSmoking.setText("Not Smoking");
        NotSmoking.setBounds(150, 240, 90,20);

        GetResult = new Button(s, SWT.PUSH);
        GetResult.setText("Get Result");
        GetResult.setBounds(340,235,80,30);

        GetResult.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent e) {
                if(age.getText().equals("0")){
                    methods.NotTrueAge();
                }
            }
        });

        Check.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent e) {
                mmol.setEnabled(Check.getSelection());
                _mmol.setEnabled(Check.getSelection());
            }
        });

        Check1.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent e) {
                mg.setEnabled(Check1.getSelection());
                _mgdl.setEnabled(Check1.getSelection());
            }
        });
    }
}