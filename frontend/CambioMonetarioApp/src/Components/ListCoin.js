import React, {useContext} from 'react';
import {StyleSheet, View, Text} from 'react-native';
import {Picker} from '@react-native-community/picker';
import CurrencyContext from '../context/CurrencyContext';
import api from '../config/api';




const ListCoin = (props) =>{
 
  const [currencyValues, setCurrency] = React.useState([]);


  getCurrency = async () => {
    try {
        const response = await api.get("/Parameters");
          setCurrency(response.data.currencies);
          alert("deu certo")
    } catch (error) {
        alert("ocorreu um erro ao pesquisar");
        console.log(error);
    }
  }
 
  React.useEffect(()=>{
    getCurrency();
  },[])
  

  const {state, dispatch } = useContext(CurrencyContext)
  

  console.warn(currencyValues);
  //const ctx  = useContext(CurrencyContext)
  //console.warn(Object.keys(ctx.state))
  //console.log(state);
  return(
    
     <Picker
      style={styles.PickerComponent}
      mode="dropdown"
      selectedValue=""
      onValueChange={(itemValor,itemIndex) =>{
        
      }}>
        {currencyValues.map(({name}, index) => {
        return (
          <>
          <Picker.Item label="escolha uma moeda" value="escolha" key={index} />
          <Picker.Item label={name} value={index} key={index}/>
          </>) 
    })}
    </Picker>
  )
}
const styles = StyleSheet.create({
  PickerComponent:{
    width: '100%',
    borderBottomWidth: 2
  },
  textoSelecionado: {
    fontWeight: 'bold',
    fontSize: 30,
    color: '#fff'
  }
})

export default ListCoin;