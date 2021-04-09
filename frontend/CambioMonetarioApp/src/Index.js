import React from 'react';
import { View, Text, StyleSheet, TextInput, TouchableOpacity, Container } from 'react-native';

import List from './Components/list';
import Header from './Components/Header';

import api from '../src/config/api';

const App = () =>{

  const [currency,setCurrency] = React.useState([]);
  
  const getCurrency = async () => {
    try {
        const response = await api.get("/parameters");
        console.log(response);
      
    } catch (error) {
        alert("ocorreu um erro ao pesquisar");
        console.log(error);
    }
}

 React.useEffect(() => {
    //getCurrency();
  }, [])

  const enviar = () =>{
    alert("enviar valores")
    getCurrency();
  } 
  return(
    <View style={estilo.container}>
    <Header></Header>
    <List></List>
      <Text style={estilo.textInput}>
        Qual valor você deseja fazer deposito?
      </Text>
      <TextInput stye={estilo.inputForm}></TextInput>
      <TextInput style={estilo.inputForm}>
      </TextInput>
      <TouchableOpacity style={estilo.submitForm} onPress={enviar}>
        <Text>
          Converter
        </Text>
      </TouchableOpacity>
    </View>
  )
}

const estilo = StyleSheet.create({
  container:{
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',

  },
  textInput:{
    fontSize: 20,
    marginBottom: 20,
    color: '#fff'
  },
  inputForm: {
    backgroundColor: '#fff',
    width: '90%',
    marginBottom: 15,
    color: '#222',
    fontSize: 18,
    borderRadius: 8,
    padding: 10
  },
  submitForm: {
    backgroundColor: '#ebb105',
    width: '80%',
    height: 45,
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 8
  },textSaldo: {
    color: '#fff',
    flexDirection: 'column-reverse'
  }

})

export default App;