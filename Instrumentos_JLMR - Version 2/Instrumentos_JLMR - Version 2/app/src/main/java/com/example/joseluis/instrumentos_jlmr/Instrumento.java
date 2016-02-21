package com.example.joseluis.instrumentos_jlmr;

/**
 * Created by JoseLuis on 04/01/2016.
 */
public class Instrumento {



    private Integer id;
    private String nombre;
    private Integer anyo;

    public Instrumento() {

    }
    public Instrumento(String nombre, Integer anyo) {

        this.nombre = nombre;
        this.anyo = anyo;
    }

    public Instrumento(Integer id, String nombre, Integer anyo) {
        this.id = id;
        this.nombre = nombre;
        this.anyo = anyo;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Integer getAnyo() {
        return anyo;
    }

    public void setAnyo(Integer anyo) {
        this.anyo = anyo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }




}
