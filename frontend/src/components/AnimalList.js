import React from 'react';
import { useSelector, useDispatch } from 'react-redux';
import NewAnimalForm from './NewAnimalForm';
import {showForm} from '../Actions/index';

function AnimalList(props) {
  const dispatch = useDispatch();
  const error = useSelector(state => state.error);
  const isLoaded = useSelector(state => state.isLoaded);
  const formVisible = useSelector(state => state.formVisible);

  function handleDelete(id) {
    console.log(id)
  }

  function handleEdit(id) {
    console.log(id)
  }

  function handleAddClick(){
    dispatch(showForm());
  }

  if (formVisible) {
    return (
      <React.Fragment>
        <NewAnimalForm />
      </React.Fragment>
    )
  } else if (error) {
    return <React.Fragment>Error: {error.message}</React.Fragment>;
  } else if (isLoaded) {
    return <React.Fragment>Loading...</React.Fragment>;
  } else {
    return (
      <React.Fragment>
        <h1>Current Inventory</h1>
        <button onClick={handleAddClick}>Add an animal</button>
        <ul>
          {props.list.map((animal, index) =>
            <div className="card" key={index}>
              <li>
                <h3>{animal.name}</h3>
                <p>{animal.type}</p>
                <p>{animal.breed}</p>
                <button onClick={() => handleDelete(animal.animalId)}>Delete</button>
                <button onClick={() => handleEdit(animal.animalId)}>Edit</button>
              </li>
            </div>
            )}
        </ul>
      </React.Fragment>
    );
  }
}

export default AnimalList;