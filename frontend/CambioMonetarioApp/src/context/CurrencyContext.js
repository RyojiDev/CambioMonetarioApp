import React, {createContext, useReducer} from 'react';
import {getCurrency} from '../service/currencyService';

const CurrencyContext = createContext({})
const currency = getCurrency();
export const CurrencyProviders = props => {
  const initialState = { currency : currency  }


function reducer(state, action){
  console.warn(action)
  const fn = actions[action.type]
  return fn ? fn(state, action) : state
}

const [state, dispatch] = useReducer(reducer, initialState);

  return (
    <CurrencyContext.Provider value={{
      state, dispatch
    }}>
     {props.children}
    </CurrencyContext.Provider>
  )
}

export default CurrencyContext;