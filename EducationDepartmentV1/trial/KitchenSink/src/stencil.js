/*! Rappid v1.7.1 - HTML5 Diagramming Framework - TRIAL VERSION

Copyright (c) 2015 client IO

 2016-03-03 


This Source Code Form is subject to the terms of the Rappid Trial License
, v. 2.0. If a copy of the Rappid License was not distributed with this
file, You can obtain one at http://jointjs.com/license/rappid_v2.txt
 or from the Rappid archive as was distributed by client IO. See the LICENSE file.*/


var Stencil = {};

Stencil.groups = {
    basic: { index: 1, label: 'Basic shapes' },
    lines: { index: 2, label: 'Links' }
};

Stencil.shapes = {

    basic: [
        new joint.shapes.basic.Rect({
            size: { width: 5, height: 3 },
            attrs: {
                rect: {
                    rx: 2, ry: 2, width: 50, height: 30,
                    fill: '#669999'
                },
                text: { text: 'rect', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 }
            }
        }),
        new joint.shapes.basic.Circle({
            size: { width: 5, height: 3 },
            attrs: {
                circle: { width: 50, height: 30, fill: '#669999' },
                text: { text: 'ellipse', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 }
            }
        }),
        new joint.shapes.devs.Atomic({
            size: { width: 4, height: 3 },
            inPorts: ['in1','in2'],
            outPorts: ['out'],
            attrs: {
                rect: { fill: '#669999', rx: 2, ry: 2 },
                '.label': { text: 'model', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 },
	        '.inPorts circle': { fill: '#f1c40f', opacity: 0.9 },
                '.outPorts circle': { fill: '#f1c40f', opacity: 0.9 },
	        '.inPorts text, .outPorts text': { 'font-size': 9 }
            }
        })

    ],

    lines: [
         new joint.shapes.basic.Rect({
             size: { width: 5, height: 3 },
             attrs: {
                 rect: {
                     rx: 2, ry: 2, width: 50, height: 30,
                     fill: '#669999'
                 },
                 text: { text: 'rect', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 }
             }
         })
         ,
       new joint.dia.Link({
                source: { x: 10, y: 20 },
                target: { x: 100, y: 20 },
                attrs: {
                    '.connection': { stroke: 'black' },
                    '.marker-source': { fill: 'blue', d: 'M 10 0 L 0 5 L 10 10 z' },
                    '.marker-target': { fill: 'blue', d: 'M 10 0 L 0 5 L 10 10 z' }
                }
       })
       //     ,
    
       //new joint.dia.Link({
       //         source: { x: 10, y: 60 },
       //         target: { x: 100, y: 60 },
       //         attrs: {
       //             '.connection': { stroke: '#E74C3C', 'stroke-width': 5 },
       //             '.marker-source': { stroke: '#E74C3C', fill: '#E74C3C', d: 'M 10 0 L 0 5 L 10 10 z' },
       //             '.marker-target': { stroke: '#E74C3C', fill: '#E74C3C', d: 'M 10 0 L 0 5 L 10 10 z' }
       //         }
       //     }),


       // new joint.dia.Link({
       //             source: { x: 10, y: 120},
       //             target: { x: 100, y: 120 },
       //             vertices: [{ x: 10, y: 120 }, { x: 45, y: 90 }, { x: 100, y: 120 }],
       //             attrs: {
       //                 '.connection': { stroke: 'black', 'stroke-width': 2 },
       //                 '.marker-source': { stroke: 'black', fill: 'black', d: 'M 10 0 L 0 5 L 10 10 z' },
       //                 '.marker-target': { stroke: 'black', fill: 'black', d: 'M 10 0 L 0 5 L 10 10 z' }
       //             }
       //         }),


       // new joint.dia.Link({
       //             source: { x: 10, y: 200 },
       //             target: { x: 100, y: 200 },
       //             vertices: [{ x: 30, y: 200 }, { x: 40, y: 250 }, { x: 40, y: 250 }],
       //             smooth: true,
       //             attrs: {
       //                 '.connection': { stroke: '#9B59B6', 'stroke-width': 2 },
       //                 '.marker-source': { stroke: '#9B59B6', fill: '#9B59B6', d: 'M24.316,5.318,9.833,13.682,9.833,5.5,5.5,5.5,5.5,25.5,9.833,25.5,9.833,17.318,24.316,25.682z' },
       //                 '.marker-target': { stroke: '#F39C12', fill: '#F39C12', d: 'M14.615,4.928c0.487-0.986,1.284-0.986,1.771,0l2.249,4.554c0.486,0.986,1.775,1.923,2.864,2.081l5.024,0.73c1.089,0.158,1.335,0.916,0.547,1.684l-3.636,3.544c-0.788,0.769-1.28,2.283-1.095,3.368l0.859,5.004c0.186,1.085-0.459,1.553-1.433,1.041l-4.495-2.363c-0.974-0.512-2.567-0.512-3.541,0l-4.495,2.363c-0.974,0.512-1.618,0.044-1.432-1.041l0.858-5.004c0.186-1.085-0.307-2.6-1.094-3.368L3.93,13.977c-0.788-0.768-0.542-1.525,0.547-1.684l5.026-0.73c1.088-0.158,2.377-1.095,2.864-2.081L14.615,4.928z' }
       //             }
       // })  
    ]
};


