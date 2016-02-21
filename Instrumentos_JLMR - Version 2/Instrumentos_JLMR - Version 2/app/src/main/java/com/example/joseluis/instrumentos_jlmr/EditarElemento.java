package com.example.joseluis.instrumentos_jlmr;

import android.content.Intent;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class EditarElemento extends AppCompatActivity implements View.OnClickListener {

    private EditText edtNameEdit, edtYearEdit,edtIdEdit;
    private Button btnEdit,btnCancel;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_editar_elemento);

        Intent i = getIntent();
        edtIdEdit = (EditText) findViewById(R.id.edtIdEdit);
        edtIdEdit.setText(String.valueOf(i.getIntExtra("id",0)));

        edtNameEdit = (EditText) findViewById(R.id.edtNameEdit);
        edtNameEdit.setText(i.getStringExtra("nombre"));

        edtYearEdit = (EditText) findViewById(R.id.edtYearEdit);
        edtYearEdit.setText(String.valueOf(i.getIntExtra("año",2000)));

        btnCancel= (Button) findViewById(R.id.btnCancel);
        btnCancel.setOnClickListener(this);

        btnEdit = (Button) findViewById(R.id.btnEdit);
        btnEdit.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btnEdit:
                if(TextUtils.isEmpty(edtNameEdit.getText().toString())||TextUtils.isEmpty(edtYearEdit.getText().toString())) {
                    Snackbar.make(v, R.string.mensajeError, Snackbar.LENGTH_SHORT).show();
                    break;
                }
                Intent i = new Intent();
                i.putExtra("id",getIntent().getIntExtra("id", 0));
                i.putExtra("name", edtNameEdit.getText().toString());
                i.putExtra("year", Integer.parseInt(edtYearEdit.getText().toString()));

                setResult(RESULT_OK, i);
                finish();
                break;
            case R.id.btnCancel:
                setResult(RESULT_CANCELED);
                finish();
                break;
    }
}}
