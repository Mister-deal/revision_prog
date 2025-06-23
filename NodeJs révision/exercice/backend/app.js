const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const Product = require('./models/product');

mongoose.connect('mongodb+srv://max:Maxime1994.@cluster0.7qlripn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0',
    { useNewUrlParser: true,
        useUnifiedTopology: true })
    .then(() => console.log('Connexion à MongoDB réussie !'))
    .catch(() => console.log('Connexion à MongoDB échouée !'));


const app = express();
app.use(express.json());

app.use((req, res, next) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Headers', 'Origin, X-Requested-With, Content, Accept, Content-Type, Authorization');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE, PATCH, OPTIONS');
    next();
});

app.put('/api/products/:id', (req, res, next) => {
    Product.updateOne({_id: req.params.id}, {...req.body, _id: req.params.id})
        .then(product => res.status(200).json({
            status: "success",
            message: "product has been updated",
        }))
        .catch(error => res.status(400).json(error));
})
app.get('/api/products', (req, res, next) => {
    Product.find({}).then((products) => res.status(200).json(products)).catch(error => res.status(400).json(error));
})
app.get('/api/products/:id', (req, res, next) => {
    Product.findOne( {_id: req.params.id} ).then((product) => {res.status(200).json(product)}).catch(error => res.status(400).json(error));
})

app.post('/api/products', (req, res, next) => {
    delete req.body._id;
    const product = new Product({
        ...req.body
    });

    product.save()
        .then(() => res.status(201).json({
            success: true,
            message: "product has been successfully created",
        }))
        .catch(() => res.status(400).json({
            success: false,
            error: 'Something went wrong',
        }));
})
app.delete('/api/products/:id', (req, res, next) => {
    Product.deleteOne({_id: req.params.id}).then(thing => res.status(200).json({status: "success", message: "the object has been deleted"})).catch(error => res.status(400).json(error));
})
module.exports = app;
