package com.example.joseluis.instrumentos_jlmr;

import android.content.Intent;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class AnyadirElemento extends AppCompatActivity implements View.OnClickListener {

    private EditText edtNameNew, edtYearNew;
    private Button btnSend;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_anyadir_elemento);


        edtNameNew = (EditText) findViewById(R.id.edtNameNew);
        edtYearNew = (EditText) findViewById(R.id.edtYearNew);

        btnSend= (Button) findViewById(R.id.btnSend);
        btnSend.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        // txtTituloEdt.setText(getIntent().getStringExtra("titulo"));

        switch (v.getId()){
            case R.id.btnSend:
                if(TextUtils.isEmpty(edtNameNew.getText().toString())||TextUtils.isEmpty(edtYearNew.getText().toString())) {
                    Snackbar.make(v, R.string.mensajeError, Snackbar.LENGTH_SHORT).show();
                    break;
                }
                Intent i = new Intent();
                i.putExtra("name",edtNameNew.getText().toString());
                i.putExtra("year",edtYearNew.getText().toString());
                setResult(RESULT_OK,i);
                finish();
                break;
        }
    }
}
